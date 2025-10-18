UPDATE AspNetUsers
SET UserType = 'User'
WHERE UserType IS NULL OR UserType = '';
