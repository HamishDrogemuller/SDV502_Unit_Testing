using CinemaApp;
using NUnit.Framework;

namespace CinemaFunctions.Test
{
    [TestFixture]
    public class TestCase1

    {
        //Adult_Before_5(int quantity, string person, string day, decimal time, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "adult", "Monday", 16, 14.50)]
        [TestCase(2, "adult", "Wednesday", 16, 29.00)]
        [TestCase(0, "adult", "Thursday", 15, -1)]
        [TestCase(4, "adult", "Monday", 18, -1)]
        [TestCase(4, "adult", "Monday", 12, 58.00)]

        //Adult before 5 test case with Arrange, Act and Assert
        public void Adult_Before_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Adult_Before_5(pr_quantity, pr_person, pr_day, pr_time);
            //Assert
            Assert.That(price == expectedAmount);

        }
    }


    [TestFixture]
    public class TestCase2
    {
        //Adult After 5 (int quantity, string person, string day, decimal time, decimal expectedAmount )

        //Test Cases
        [TestCase(1, "adult", "Sunday", 17, 17.50)]
        [TestCase(3, "adult", "Saturday", 19, 52.50)]
        [TestCase(1, "adult", "Monday", 18, 17.50)]
        [TestCase(1, "adult", "Tuesday", 17, -1)]
        [TestCase(2, "student", "Friday", 19, -1)]

        //Adult after 5 test case with Arrange, Act and Assert
        public void Adult_After_5(int pr_quantity, string pr_person, string pr_day, decimal pr_time, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Adult_After_5(pr_quantity, pr_person, pr_day, pr_time);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase3
    {
        //Adult Tuesday(int quantity, string person, string day, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "adult", "Tuesday", 13.00)]
        [TestCase(3, "adult", "Tuesday", 39.00)]
        [TestCase(25, "adult", "Tuesday", 325.00)]
        [TestCase(5, "adult", "Tuesday", 65.00)]
        [TestCase(4, "adult", "Monday", -1)]

        //Adult on Tuesday test case with Arrange, Act and Assert
        public void Adult_Tuesday(int pr_quantity, string pr_person, string pr_day, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Adult_Tuesday(pr_quantity, pr_person, pr_day);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase4
    {
        // Child Under 16(int quantity, string person, decimal expectedAmount)

        //Test Cases
        [TestCase(6, "child", 72.00)]
        [TestCase(60, "child", 720.00)]
        [TestCase(1, "student", -1)]
        [TestCase(20, "child", 240.00)]
        [TestCase(16, "child", 192.00)]

        //Child under 16 test case with Arrange, Act and Assert
        public void Child_Under_16(int pr_quantity, string pr_person, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Child_Under_16(pr_quantity, pr_person);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase5
    {
        //Senior(int quantity, string person, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "Senior", 12.50)]
        [TestCase(20, "Senior", 250.00)]
        [TestCase(3, "adult", -1)]
        [TestCase(5, "Senior", 62.50)]
        [TestCase(2, "Senior", 25.00)]

        //Senior test case with Arrange, Act and Assert
        public void Senior(int pr_quantity, string pr_person, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Senior(pr_quantity, pr_person);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase6
    {
        //Student(int quantity, string person, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "student", 14.00)]
        [TestCase(3, "student", 42.00)]
        [TestCase(5, "student", 70.00)]
        [TestCase(1, "adult", -1)]
        [TestCase(2, "student", 28.00)]

        //Student test case with Arrange, Act and Asserts
        public void Student(int pr_quantity, string pr_person, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Student(pr_quantity, pr_person);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase7
    {
        //Family_Pass(int quantity_ticket, int quantity_adult, int quantity_child, decimal expectedAmount)

        //Test Cases
        [TestCase(1, 1, 3, 46.00)]
        [TestCase(1, 2, 2, 46.00)]
        [TestCase(1, 3, 1, -1)]
        [TestCase(1, 1, 2, -1)]
        [TestCase(1, 4, 0, -1)]

        //Family pass test case with Arrange, Act and Assert
        public void Family_Pass(int pr_quantity_ticket, int pr_quantity_adult, int pr_quantity_child, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Family_Pass(pr_quantity_ticket, pr_quantity_adult, pr_quantity_child);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase8
    {
        //Chick Flick Thursday(int quantity, string person, string day, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "adult", "Thursday", 21.50)]
        [TestCase(3, "adult", "Thursday", 64.50)]
        [TestCase(8, "adult", "Thursday", 172.00)]
        [TestCase(32, "adult", "Thursday", 688.00)]
        [TestCase(2, "adult", "Friday", -1)]

        //Chick flick Thursday test case with Arrange, Act and Assert
        public void Chick_Flick_Thursday(int pr_quantity, string pr_person, string pr_day, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Chick_Flick_Thursday(pr_quantity, pr_person, pr_day);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }

    [TestFixture]
    public class TestCase9
    {
        // Kids Careers(int quantity, string day, bool holiday, decimal expectedAmount)

        //Test Cases
        [TestCase(1, "Wednesday", false, 12.00)]
        [TestCase(3, "Wednesday", false, 36.00)]
        [TestCase(5, "Wednesday", false, 60.00)]
        [TestCase(21, "Wednesday", false, 252.00)]
        [TestCase(6, "Wednesday", true, -1)]

        //Kids Careers test case with Arrange, Act and Assert.
        public void Kids_Careers(int pr_quantity, string pr_day, bool pr_holiday, decimal expectedAmount)
        {
            //Arrange
            TicketPriceController TPC = new TicketPriceController();
            //Act
            decimal price = TPC.Kids_Careers(pr_quantity, pr_day, pr_holiday);
            //Assert
            Assert.That(price == expectedAmount);
        }
    }


}
