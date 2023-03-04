const odbc = require('odbc');

 
async function queryAccess() {
const connection = await odbc.connect(`DSN=DB_2`);
const data = await connection.query('SELECT * FROM grades');
console.log(data);
}
 
queryAccess();