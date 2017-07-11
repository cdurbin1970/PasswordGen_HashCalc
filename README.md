# PasswordGen_HashCalc
Utility to generate passwords and to compute hashes on files and text.

This utility has the ability to generate variable length passwords using several
different character sets:

PASSWORD_LCASE "abcdefgijkmnopqrstwxyz"
PASSWORD_UCASE "ABCDEFGHJKLMNPQRSTWXYZ"
PASSWORD_NUMERIC "23456789"
PASSWORD_SPECIAL "*$-+?_&=!%{}/"
PASSWORD_ADDITIONAL "IO10"
PASSWORD_HEX_LCASE "abcdef0123456789"
PASSWORD_HEX_UCASE "ABCDEF0123456789"

You can use individual groups or mix and match to suit your needs. The regular
sets do not include the characters I,O,1 or 0 to avoid cunfusion. Add those 
characters in by using the Additional set. 

It can also compute hashes for both files and text. It can compute MD5, SHA1,
SHA256 and SHA512. If you paste a hash into compare box, it will compare it
against the generated hashes to see if there is a match. 