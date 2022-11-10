using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void Score8_should_ReturnA()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7dot5_should_ReturnB()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Tuan";
            s.Age = 30;
            s.Score = 7.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score7_should_ReturnB()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Anh";
            s.Age = 30;
            s.Score = 7;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Score6dot5_should_ReturnC()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Anh";
            s.Age = 30;
            s.Score = 6.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score3dot5_should_ReturnD()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Anh";
            s.Age = 30;
            s.Score = 3.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score2_should_ReturnE()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Anh";
            s.Age = 30;
            s.Score = 2;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);
        }
        [TestMethod]
        public void Score5_should_ReturnC()
        {
            Student s = new Student();

            s.Id = 1;
            s.Name = "Anh";
            s.Age = 30;
            s.Score = 5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void addFirstStudent()
        {
            StudentService SV = new StudentService();
            Student sv = new Student()
            {
                Id = 1,
                Name = "Anh",
                Age = 10,
                Score = 10,
            };

            bool status = SV.addStudent(sv);

            Assert.IsTrue(status);

            int size = SV.size();
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void addSecondStudent()
        {
            StudentService SV = new StudentService();
            try
            {
                Student sv = null;
                
                bool status = SV.addStudent(sv);
            } catch (NullReferenceException)
            {
                Console.WriteLine("Có lỗi rồi");
            }
            

            
        }

        
    }
}

 
