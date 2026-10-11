import java.sql.*;
public class DBconnJ {
 
public static void main(String[] args) throws Exception {
try
{
Class.forName("oracle.jdbc.driver.OracleDriver");
try (Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","scott","tiger")) {
Statement st = con.createStatement();
ResultSet rs = st.executeQuery("select * from salgrade");
while (rs.next())
{
System.out.println("Grade:: "+rs.getInt(1)+ " losal:: "+rs.getInt(2)+ " Hisal ::" + rs.getInt(3));
} rs.close();
//st.close();
}
}
catch (Exception s) {
System.out.println(s);}
}
}