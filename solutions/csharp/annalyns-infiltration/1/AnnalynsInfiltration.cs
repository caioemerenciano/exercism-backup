static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => 
        !knightIsAwake;

    
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => 
        knightIsAwake || archerIsAwake || prisonerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => 
        !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool canRescueWithDog = !archerIsAwake && petDogIsPresent;
        bool canRescueWithoutDog = !petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake;

        return canRescueWithDog || canRescueWithoutDog;
    }
}
