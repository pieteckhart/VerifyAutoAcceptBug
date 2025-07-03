namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var result = await Verify($"{Environment.OSVersion.Platform} {DateTime.Now}")
                .AutoVerify(includeBuildServer: false, throwException: false);
        }
    }
}