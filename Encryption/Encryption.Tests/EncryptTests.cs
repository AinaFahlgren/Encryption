namespace Caesar;
public class CaesarChifferTest1
{
    [Fact]
    public void EncryptCaesar()
    {
        // Given
        string myName = "name";
        int shift = 3;
        string expectedResult = "qdph";

        // When
        string result = CaesarChiffer.EncryptCaesar(myName, shift);

        // Then
        Assert.Equal(expectedResult, result);
    }
}