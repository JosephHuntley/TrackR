using TrackR.DataContext.SQL;

namespace TrackR.Common.UnitTests;

public class DbTest
{
    [Fact]
    public void CanConnectIsTrue()
    {
        using (SqlContext db = new()) // arrange
        {
            bool canConnect = db.Database.CanConnect(); // act
            Assert.True(canConnect); // assert
        }
    }
}