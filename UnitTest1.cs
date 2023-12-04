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
            Book bk = new Book("����������� �����", "�.�. ������", 500);
            Assert.AreEqual("����������� �����", bk.Title);
        }
        [TestMethod]
        public void TestBookGetAuthor()
        {
            Book bk = new Book("����������� �����", "�.�. ������", 500);
            Assert.AreEqual("�.�. ������", bk.Author);
        }
        [TestMethod]
        public void TestBookGetPrice()
        {
            Book bk = new Book("����������� �����", "�.�. ������", 500);
            Assert.AreEqual(500, bk.Price);
        }
        [TestMethod]
        public void TestBookGenreGetGenre()
        {
            BookGenre bk = new BookGenre("����������� �����", "�.�. ������", 500,"������������ �����");
            Assert.AreEqual("������������ �����", bk.Genre);
        }
        [TestMethod]
        public void TestBookGenrePublGetPublisher()
        {
            BookGenrePubl bk = new BookGenrePubl("����������� �����", "�.�. ������", 500, "������������ �����", "������");
            Assert.AreEqual("������", bk.Publisher);
        }
        [TestMethod]
        public void TestTriangleGetName()
        {
            Triangle trgl = new Triangle("����",4,2,5);
            Assert.AreEqual("����", trgl.Name);
        }
        [TestMethod]
        public void TestTriangleGetArea()
        {
            Triangle trgl = new Triangle("����", 3, 4, 5);
            Assert.AreEqual(6, trgl.Area2);
        }
        [TestMethod]
        public void TestTriangleGetABC()
        {
            Triangle trgl = new Triangle("����", 3, 4, 5);
            Assert.AreEqual((3, 4, 5), trgl.GetABC());
        }
        [TestMethod]
        public void TestTriangleSetABC()
        {
            Triangle trgl = new Triangle("����", 1, 2, 5);
            trgl.SetABC(3, 4, 5);
            Assert.AreEqual((3, 4, 5), trgl.GetABC());
        }
        [TestMethod]
        public void TestTriangleColorGetColor()
        {
            TriangleColor trgl = new TriangleColor("����", 1, 2, 5,"�������");
            trgl.SetABC(3, 4, 5);
            Assert.AreEqual("�������", trgl.Color);
        }
        [TestMethod]
        public void TestTriangleColorSetColor()
        {
            TriangleColor trgl = new TriangleColor("����", 1, 2, 5, "�������");
            trgl.SetABC(3, 4, 5);
            trgl.Color = "�����";
            Assert.AreEqual("�����", trgl.Color);
        }
    }
}