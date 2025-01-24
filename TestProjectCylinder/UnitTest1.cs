using CylinderProject.Models;
namespace TestProjectCylinder
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cyl = new Cylinder(5, 10);

            Assert.Equal(5, cyl.Radius);
            Assert.Equal(10, cyl.Height);
        }

        [Fact]
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() => new Cylinder(0, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(10, 0));
            Assert.Throws<ArgumentException>(() => new Cylinder(-10, 10));
            Assert.Throws<ArgumentException>(() => new Cylinder(10, -10));
        }
        [Fact]
        public void Test3()
        {
            var cyl = new Cylinder(5, 10);

            Assert.Equal(Math.Round(cyl.GetVolume()), Math.Round((cyl.Radius * cyl.Radius) * Math.PI * cyl.Height));
            Assert.Equal(Math.Round(cyl.GetSurfaceArea()), Math.Round(2 * (cyl.Radius * cyl.Radius) * Math.PI + 2 * cyl.Radius * Math.PI * cyl.Height));
        }

        [Fact]
        public void Test4()
        {
            var cyl = new Cylinder(5, 10);

            cyl.Resize(10, 5);

            Assert.Equal(10, cyl.Radius);
            Assert.Equal(5, cyl.Height);

            Assert.Throws<ArgumentException>(() => cyl.Resize(0, 10));
            Assert.Throws<ArgumentException>(() => cyl.Resize(-5, 10));
            Assert.Throws<ArgumentException>(() => cyl.Resize(5, 0));
            Assert.Throws<ArgumentException>(() => cyl.Resize(5, -10));
        }

        [Fact]
        public void Test5()
        {
            var cyl = new Cylinder(5, 10);

            Assert.NotNull(cyl);
        }

        [Fact]
        public void Test6()
        {
            var cyl = new Cylinder(5, 10);

            Assert.InRange(cyl.Radius, 1, 100);
        }
    }
}