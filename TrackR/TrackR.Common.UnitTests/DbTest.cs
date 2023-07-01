using TrackR.DataContext.SQL;
using TrackR.Models.SQL;

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
    
    [Fact]
    public void ProviderIsSqlServer()
    {
        using (SqlContext db = new())
        {
            string? provider = db.Database.ProviderName;
            Assert.Equal("Microsoft.EntityFrameworkCore.SqlServer", provider);
        }
    }

    [Fact]
    public void User1IsJoseph()
    {
        using (SqlContext db = new())
        {
            User user = db.Users.Single(u => u.UserId == 1);
            Assert.Equal("Joseph",user.FirstName );
        }
        {
            
        }
    }
}