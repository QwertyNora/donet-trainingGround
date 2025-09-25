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
        return AgeCategory.Kid;
    }
}
