using raster;

namespace test;

public class Test
{
    [Fact]
    public void TestFileExists()
    {
        // setup        
        var draw = new Draw();        
        draw.drawing("../../../");

        Assert.True(File.Exists("output.png"));
    }
}