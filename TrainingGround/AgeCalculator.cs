namespace TrainingGround;

public enum AgeCategory
{
    Kid,
    Adult
}

public class AgeCalculator
{

    public static int GetAge(int birthYear, int currentYear)
    {
        return currentYear - birthYear;
    }

    public static AgeCategory GetAgeCategory(Person person, int currentYear)
    {
        var isOlderThan18 = person.GetAge(currentYear) > 18;

        if (isOlderThan18)
        {
            return AgeCategory.Adult;
        }
        return AgeCategory.Kid;

    }
}
