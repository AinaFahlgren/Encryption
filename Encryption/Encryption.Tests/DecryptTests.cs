namespace Caesar;
public class CaesarChifferTest2
{
    [Fact]
    public void DecryptCaesar()
    {
        // Given
        string myName = "qdph";
        int shift = 3;
        string expectedResult = "name";

        // When
        string result = CaesarChiffer.DecryptCaesar(myName, shift);

        // Then
        Assert.Equal(expectedResult, result);
    }
}