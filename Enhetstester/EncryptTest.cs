using Xunit;

namespace Caesar;
public class CaesarChifferTest1
{
    [Fact]
    public void EncryptCaesar()
    {
        // Given
        CaesarChiffer chiffer = new();
        string myName = "name";
        int shift = 3;
        string expectedResult = "qdph";

        // When
        string result = chiffer.Encrypt_CaesarChiffer(myName, shift);

        // Then
        Assert.Equal(expectedResult, result);
    }
}