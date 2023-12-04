using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5_3._2;
using HW5_2;

namespace HW5_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBookGetTitle()
        {
            Book bk = new Book("Капитанская дочка", "А.С. Пушкин", 500);
            Assert.AreEqual("Капитанская дочка", bk.Title);
        }
        [TestMethod]
        public void TestBookGetAuthor()
        {
            Book bk = new Book("Капитанская дочка", "А.С. Пушкин", 500);
            Assert.AreEqual("А.С. Пушкин", bk.Author);
        }
        [TestMethod]
        public void TestBookGetPrice()
        {
            Book bk = new Book("Капитанская дочка", "А.С. Пушкин", 500);
            Assert.AreEqual(500, bk.Price);
        }
        [TestMethod]
        public void TestBookGenreGetGenre()
        {
            BookGenre bk = new BookGenre("Капитанская дочка", "А.С. Пушкин", 500,"Исторический роман");
            Assert.AreEqual("Исторический роман", bk.Genre);
        }
        [TestMethod]
        public void TestBookGenrePublGetPublisher()
        {
            BookGenrePubl bk = new BookGenrePubl("Капитанская дочка", "А.С. Пушкин", 500, "Исторический роман", "Азбука");
            Assert.AreEqual("Азбука", bk.Publisher);
        }
        [TestMethod]
        public void TestTriangleGetName()
        {
            Triangle trgl = new Triangle("Круг",4,2,5);
            Assert.AreEqual("Круг", trgl.Name);
        }
        [TestMethod]
        public void TestTriangleGetArea()
        {
            Triangle trgl = new Triangle("Круг", 3, 4, 5);
            Assert.AreEqual(6, trgl.Area2);
        }
        [TestMethod]
        public void TestTriangleGetABC()
        {
            Triangle trgl = new Triangle("Круг", 3, 4, 5);
            Assert.AreEqual((3, 4, 5), trgl.GetABC());
        }
        [TestMethod]
        public void TestTriangleSetABC()
        {
            Triangle trgl = new Triangle("Круг", 1, 2, 5);
            trgl.SetABC(3, 4, 5);
            Assert.AreEqual((3, 4, 5), trgl.GetABC());
        }
        [TestMethod]
        public void TestTriangleColorGetColor()
        {
            TriangleColor trgl = new TriangleColor("Круг", 1, 2, 5,"Красный");
            trgl.SetABC(3, 4, 5);
            Assert.AreEqual("Красный", trgl.Color);
        }
        [TestMethod]
        public void TestTriangleColorSetColor()
        {
            TriangleColor trgl = new TriangleColor("Круг", 1, 2, 5, "Красный");
            trgl.SetABC(3, 4, 5);
            trgl.Color = "Синий";
            Assert.AreEqual("Синий", trgl.Color);
        }
    }
}