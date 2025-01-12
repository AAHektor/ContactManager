using ContactManager.Helpers;

namespace ContactManager.Tests.Helpers;

public class UniqueIdentifierGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        string id = UniqueIdentifierGenerator.Generate();

        Assert.False(string.IsNullOrEmpty(id));

        Assert.True(Guid.TryParse(id, out _));
    }

    [Fact]
    public void Generate_ShouldNotReturnNullOrEmptyId()
    {
        string id = UniqueIdentifierGenerator.Generate();

        Assert.NotNull(id);
        Assert.NotEmpty(id);
    }

    [Fact]
    /* Detta är genererat av Chat GPT 4o - Denna kod kontrollerar att genererade ID:n är både giltigt GUID och har rätt format.
     * Först genererar den ett id med hjälp av metoden Generate(). Sedan Guid.tryParse för att kontrollera om det är ett giltigt ID.
     Regex kontrollera att GUID är i rätt format och att det följer exakt 36 tecken. 
    */
    public void Generate_ShouldReturnIdInCorrectFormat()
    {
        string id = UniqueIdentifierGenerator.Generate();

        // Kontrollera om det är ett giltigt GUID med Guid.TryParse
        bool isValidGuid = Guid.TryParse(id, out _);
        Assert.True(isValidGuid, "The generated ID is not a valid GUID.");

        // Kontrollera om GUID är i rätt format med hjälp av Regex
        var regex = new System.Text.RegularExpressions.Regex(@"^[a-fA-F0-9\-]{36}$");
        bool isValidFormat = regex.IsMatch(id);
        Assert.True(isValidFormat, "The generated ID does not match the expected GUID format.");
    }


}
