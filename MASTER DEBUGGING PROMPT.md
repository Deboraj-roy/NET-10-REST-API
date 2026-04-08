
Act as a senior .NET debugger.
Analyze this error step-by-step:
1. Root cause
2. What file/config is wrong
3. Exact fix with commands/code
4. Why it happened
5. How to prevent it

Do not guess. Use best practices only.

Error: 

I am running a .NET 10 Minimal API project and encountering an issue.

Your job is NOT to guess — you must diagnose systematically.

Follow this troubleshooting process strictly:

STEP 1 — Understand the Problem

* Read the error message carefully
* Identify whether the issue is build-time, runtime, database, configuration, dependency, or environment related

STEP 2 — Root Cause Analysis

* Explain WHY the error happens
* Point to the exact file/configuration causing it
* Mention common reasons this occurs in ASP.NET Core projects

STEP 3 — Verify Checklist
Provide a checklist to confirm:

* .NET SDK version
* NuGet packages
* Connection string correctness
* EF migrations status
* Program.cs configuration
* appsettings.json issues
* Missing services or DI registration

STEP 4 — Provide Best Fix

* Give the cleanest and safest solution
* Show exact code changes or commands
* Avoid workaround hacks unless necessary

STEP 5 — Prevention Advice

* Explain how to prevent this issue in future
* Mention best practices

OUTPUT RULES:

* Be concise but complete
* Show commands in terminal format
* Show corrected code blocks fully
* Do NOT give multiple random solutions
* Prefer official Microsoft-recommended approaches

Now analyze the following error:

[PASTE ERROR MESSAGE HERE]



--
##=============================

Act as a production support engineer for ASP.NET Core.

Diagnose this running application issue using this order:

1. Logs analysis
2. Dependency Injection validation
3. Database connectivity
4. Middleware pipeline order
5. Endpoint mapping
6. Environment configuration

Provide:

* root cause
* exact fix
* corrected code
* verification steps

Error/logs:
[PASTE LOG HERE]



