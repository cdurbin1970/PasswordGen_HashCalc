# PasswordGen_HashCalc
Utility to generate passwords and to compute hashes on files and text.

This is written in C# and .NET 4.5.2 using VS 2015
It uses the Bouncy Castle library for certain crypto functions.
https://www.bouncycastle.org/csharp/index.html

This utility has the ability to generate variable length passwords using several different character sets:

PASSWORD_LCASE "abcdefgijkmnopqrstwxyz"<br/>
PASSWORD_UCASE "ABCDEFGHJKLMNPQRSTWXYZ"<br/>
PASSWORD_NUMERIC "23456789"<br/>
PASSWORD_SPECIAL "*$-+?_&=!%{}/"<br/>
PASSWORD_ADDITIONAL "IO10"<br/>
PASSWORD_HEX_LCASE "abcdef0123456789"<br/>
PASSWORD_HEX_UCASE "ABCDEF0123456789"<br/>
<br/>
You can use individual groups or mix and match to suit your needs. The regular
sets do not include the characters I,O,1 or 0 to avoid cunfusion. Add those 
characters in by using the Additional set. 

It can also compute hashes for both files and text. It can compute MD5, SHA1,
SHA256, SHA512, Gost, RipeMD128, RipeMD160, RipeMD256, RipeMD320, Tiger and Whirlpool. 
If you paste a hash into compare box, it will compare it against the generated hashes to 
see if there is a match. 

This uses the MS hash functions for MD5 and SHAx generation. The MS functions are MUCH
faster than the Bouncy Castle algorithms on large files.
