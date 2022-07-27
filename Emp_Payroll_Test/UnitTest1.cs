using Emp_Payroll_ADO.NET;
namespace Emp_Payroll_Test
{
    [TestClass]
    
    public class Emp_Payroll_Test
    {
        [TestMethod]
        public void UpdateData()
        {
            Connection con = new Connection();
            var result = con.UpdateData();
            Assert.AreEqual(400000, result);
        }
        [TestMethod]
        public void RetrieveDataByNameTest()
        {
            Connection con = new Connection();
            var result = con.RetrieveDataByName();
            Assert.AreEqual("Ayub ", result);
        }
        [TestMethod]
        public void RetrieveFromDate()
        {
            Connection con = new Connection();
            var result = con.RetrieveFromDate();
            Assert.AreEqual(null, result);
        }
        [TestMethod]
        public void SumofMale()
        {
            Salary con = new Salary();
            var result = con.SumofMale();
            Assert.AreEqual(800000, result);
        }
        [TestMethod]
        public void SumofFemale()
        {
            Salary con = new Salary();
            var result = con.SumofFemale();
            Assert.AreEqual(8800000, result);
        }
        [TestMethod]
        public void AvgofMale()
        {
            Salary con = new Salary();
            var result = con.AvgofMale();
            Assert.AreEqual(266666, result);
        }
        [TestMethod]
        public void AvgofFemale()
        {
            Salary con = new Salary();
            var result = con.AvgofFemale();
            Assert.AreEqual(2200000, result);
        }
        [TestMethod]
        public void MinofMale()
        {
            Salary con = new Salary();
            var result = con.MinofMale();
            Assert.AreEqual(100000, result);
        }
        [TestMethod]
        public void MinofFemale()
        {
            Salary con = new Salary();
            var result = con.MinofFemale();
            Assert.AreEqual(800000, result);
        }
        [TestMethod]
        public void MaxofMale()
        {
            Salary con = new Salary();
            var result = con.MaxofMale();
            Assert.AreEqual(500000, result);
        }
        [TestMethod]
        public void MaxofFemale()
        {
            Salary con = new Salary();
            var result = con.MaxofFemale();
            Assert.AreEqual(4000000, result);
        }
    }
}
