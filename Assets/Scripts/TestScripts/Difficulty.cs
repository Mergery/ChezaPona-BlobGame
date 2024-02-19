using UnityEngine;

public static class  Difficulty
{
    static float secondsToMaxDifficulty = 200f; 
    static float secondsToMaxDifficulty2= 400f;

    public static float GetDifficultyPercentage()
    {
        if(Time.timeSinceLevelLoad<secondsToMaxDifficulty)
        {
            return Mathf.Clamp01(Time.timeSinceLevelLoad/secondsToMaxDifficulty);
        }
        else 
        {
            float percent = Random.Range(0f,1.0f);
            return percent;
        }
    }

    public static float GetDifficultyPercentage2()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad/secondsToMaxDifficulty2);//
    }
    
}
