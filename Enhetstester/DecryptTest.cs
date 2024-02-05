using Xunit;

namespace Caesar;
public class CaesarChifferTest2
{
    [Fact]
    public void DecryptCaesar()
    {
        // Given
        CaesarChiffer chiffer = new();
        string myName = "name";
        int shift = 3;
        string expectedResult = "qdph";

        // When
        string result = chiffer.Decrypt_CaesarChiffer(myName, shift);

        // Then
        Assert.Equal(expectedResult, result);
    }
}