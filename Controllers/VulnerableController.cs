using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ShipServicesApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VulnerableController : ControllerBase
    {
        // Hard-coded credentials vulnerability
        private const string DatabasePassword = "P@ssw0rd123!";
        private const string ApiKey = "sk-1234567890abcdef";
        
        // SQL Injection vulnerability
        [HttpGet("search")]
        public IActionResult SearchShips(string shipName)
        {
            var connectionString = $"Server=localhost;Database=ShipDB;User Id=admin;Password={DatabasePassword};";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Vulnerable: Direct string concatenation in SQL query
                var query = $"SELECT * FROM Ships WHERE ShipName = '{shipName}'";
                var command = new SqlCommand(query, connection);
                var result = command.ExecuteScalar();
                return Ok(result);
            }
        }

        // Command Injection vulnerability
        [HttpPost("ping")]
        public IActionResult PingServer(string hostname)
        {
            // Vulnerable: Unvalidated user input passed to shell command
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"ping -c 3 {hostname}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                }
            };
            process.Start();
            var output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return Ok(output);
        }

        // Path Traversal vulnerability
        [HttpGet("download")]
        public IActionResult DownloadFile(string filename)
        {
            // Vulnerable: No path validation
            var filePath = $"/var/www/files/{filename}";
            if (System.IO.File.Exists(filePath))
            {
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/octet-stream", filename);
            }
            return NotFound();
        }

        // XSS vulnerability - Reflected
        [HttpGet("welcome")]
        public ContentResult Welcome(string username)
        {
            // Vulnerable: Unencoded user input in HTML response
            var html = $"<html><body><h1>Welcome {username}!</h1></body></html>";
            return Content(html, "text/html");
        }

        // Insecure Deserialization vulnerability
        [HttpPost("deserialize")]
        public IActionResult DeserializeData([FromBody] string jsonData)
        {
            // Vulnerable: Deserializing untrusted data with TypeNameHandling
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var obj = JsonConvert.DeserializeObject(jsonData, settings);
            return Ok(obj);
        }

        // Weak Random Number Generation
        [HttpGet("token")]
        public IActionResult GenerateToken()
        {
            // Vulnerable: Using non-cryptographic Random for security token
            var random = new Random();
            var token = random.Next(100000, 999999);
            return Ok(new { token = token });
        }

        // Missing Authentication
        [HttpDelete("delete-all")]
        public IActionResult DeleteAllShips()
        {
            // Vulnerable: No authentication/authorization check
            // Delete all ships logic
            return Ok("All ships deleted");
        }

        // Weak Cryptography
        [HttpPost("encrypt")]
        public IActionResult EncryptData(string data)
        {
            // Vulnerable: Using weak/outdated encryption
            var key = "12345678"; // Weak key
            var encrypted = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
            return Ok(encrypted);
        }

        // Information Disclosure
        [HttpGet("error")]
        public IActionResult TriggerError()
        {
            try
            {
                throw new Exception("Database connection failed: Server=prod-db.internal;User=admin;Password=Secret123");
            }
            catch (Exception ex)
            {
                // Vulnerable: Exposing sensitive information in error messages
                return BadRequest(new { error = ex.Message, stackTrace = ex.StackTrace });
            }
        }

        // LDAP Injection
        [HttpGet("ldap-search")]
        public IActionResult LdapSearch(string username)
        {
            // Vulnerable: Unvalidated LDAP query
            var filter = $"(uid={username})";
            return Ok($"LDAP Query: {filter}");
        }

        // XML External Entity (XXE) vulnerability
        [HttpPost("parse-xml")]
        public IActionResult ParseXml([FromBody] string xmlContent)
        {
            // Vulnerable: XML parser without XXE protection
            var xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(xmlContent);
            return Ok(xmlDoc.InnerText);
        }
    }
}
