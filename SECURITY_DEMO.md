# GitHub Advanced Security Demo

This application contains **intentional security vulnerabilities** for demonstrating GitHub Advanced Security features.

## ⚠️ WARNING
**DO NOT use this code in production!** These vulnerabilities are intentionally included for educational and demonstration purposes only.

## Security Features Demonstrated

### 1. Code Scanning (CodeQL)
The `VulnerableController.cs` contains multiple code-level vulnerabilities that CodeQL will detect:

#### SQL Injection (CWE-89)
- **Location**: `SearchShips` method
- **Issue**: Direct string concatenation in SQL query
- **Risk**: Attacker can manipulate database queries

#### Command Injection (CWE-78)
- **Location**: `PingServer` method  
- **Issue**: Unvalidated user input passed to shell command
- **Risk**: Arbitrary command execution on server

#### Path Traversal (CWE-22)
- **Location**: `DownloadFile` method
- **Issue**: No validation of file paths
- **Risk**: Access to unauthorized files via `../` sequences

#### Cross-Site Scripting (CWE-79)
- **Location**: `Welcome` method
- **Issue**: Unencoded user input in HTML response
- **Risk**: Script injection in user's browser

#### Insecure Deserialization (CWE-502)
- **Location**: `DeserializeData` method
- **Issue**: TypeNameHandling.All allows arbitrary type instantiation
- **Risk**: Remote code execution

#### Hard-coded Credentials (CWE-798)
- **Location**: Class constants
- **Issue**: Passwords and API keys in source code
- **Risk**: Credential exposure in version control

#### Weak Cryptography
- **Location**: `GenerateToken` and `EncryptData` methods
- **Issue**: Non-cryptographic random and Base64 "encryption"
- **Risk**: Predictable tokens and weak data protection

#### Information Disclosure
- **Location**: `TriggerError` method
- **Issue**: Exposing stack traces and sensitive error details
- **Risk**: Leaking internal system information

#### Missing Authentication
- **Location**: `DeleteAllShips` method
- **Issue**: No authentication checks on critical operations
- **Risk**: Unauthorized access to sensitive operations

#### LDAP Injection (CWE-90)
- **Location**: `LdapSearch` method
- **Issue**: Unvalidated LDAP filter construction
- **Risk**: LDAP query manipulation

#### XML External Entity (XXE) (CWE-611)
- **Location**: `ParseXml` method
- **Issue**: XML parser without XXE protection
- **Risk**: Information disclosure, SSRF, DoS

### 2. Dependency Scanning (Dependabot)
The project includes known vulnerable package versions:

| Package | Vulnerable Version | Known CVEs |
|---------|-------------------|------------|
| Newtonsoft.Json | 9.0.1 | GHSA-5crp-9r3c-p9vr (High) |
| Npgsql | 4.1.2 | GHSA-x9vc-6hfv-hg8c (High) |
| SharpZipLib | 1.2.0 | GHSA-m22m-h4rf-pwq3 (High), GHSA-mm6g-mmq6-53ff (Moderate) |
| System.Text.Encodings.Web | 4.5.0 | GHSA-ghhp-997w-qr28 (Critical) |
| BouncyCastle | 1.8.5 | Multiple known vulnerabilities |

### 3. Secret Scanning
Hard-coded secrets that will be detected:
- Database passwords
- API keys  
- Connection strings with credentials

## Enabling GitHub Advanced Security

### For GitHub Enterprise Cloud or Enterprise Server:

1. **Enable GHAS for your repository**:
   - Go to Settings → Security & analysis
   - Enable "GitHub Advanced Security"

2. **Enable Dependabot alerts**:
   - Enable "Dependabot alerts"
   - Enable "Dependabot security updates"

3. **Enable Code scanning**:
   - Enable "Code scanning"
   - The CodeQL workflow is already configured in `.github/workflows/codeql.yml`

4. **Enable Secret scanning**:
   - Enable "Secret scanning"
   - Enable "Push protection" (optional)

### For Public Repositories:
All these features are available for free!

## Viewing Security Alerts

After pushing this code:

1. **Security tab** → View all security alerts
2. **Dependabot alerts** → See vulnerable dependencies
3. **Code scanning alerts** → See code vulnerabilities detected by CodeQL
4. **Secret scanning alerts** → See detected secrets (if any match patterns)

## Fixing the Vulnerabilities

To fix these issues:

1. **Remove** or **quarantine** the `VulnerableController.cs` file
2. **Update** all package versions to their latest secure versions
3. **Remove** hard-coded credentials and use secure configuration
4. **Implement** proper input validation and parameterized queries
5. **Review** and remediate all CodeQL findings

## Learning Resources

- [GitHub Advanced Security Documentation](https://docs.github.com/en/code-security)
- [CodeQL Documentation](https://codeql.github.com/docs/)
- [OWASP Top 10](https://owasp.org/www-project-top-ten/)
- [CWE/SANS Top 25](https://cwe.mitre.org/top25/)
