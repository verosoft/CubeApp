namespace CubeApplicationService
{
    public interface ICubeIntersectionApp
    {
        double GetIntersectedVolume(string dimensionA, string dimensionB, string xA, string xB, string yA, string yB, string zA, string zB);
    }
}