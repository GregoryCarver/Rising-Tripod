using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

//Things to do: -Deal with reaching max level, should it go to 100?

public static class LevelUpManager
{
    private const int maxLevel = 99;
    private const int maxExp = 9999999;

    //Used to store difference between the base stat for that level, and the actual value including bonuses gained from items or other means.
    private static int tempStatMod;

    public static void CheckForLevelUp(BasePlayableCharacter character)
    {
        while(character.CurrExp >= character.ExpToNextLevel)
        {
            LevelUp(character);
        }
    }

    //Calls the various methods that increase each stat.
    public static void LevelUp(BasePlayableCharacter character)
    {
        if (character.CurrLevel == 0)
        {
            character.CurrLevel++;
            character.ExpToNextLevel = GetExpNeeded(character.CurrLevel);
            character.Strength = (int)Math.Floor(Math.Sqrt((200 + (character.StrengthPotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.Defense = (int)Math.Floor(Math.Sqrt((200 + (character.DefensePotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.Intelligence = (int)Math.Floor(Math.Sqrt((200 + (character.IntelligencePotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.Will = (int)Math.Floor(Math.Sqrt((200 + (character.WillPotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.Speed = (int)Math.Floor(Math.Sqrt((200 + (character.SpeedPotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.Agility = (int)Math.Floor(Math.Sqrt((200 + (character.AgilityPotential * 10)) * (character.CurrLevel + 8)) - 35);
            character.MaxHp = (int)Math.Floor((60 + character.MaxHpPotential) * Math.Log10(character.CurrLevel + 7) + 177 - (50 * character.CurrLevel));
            character.MaxMp = (int)Math.Floor(((Math.Log10(character.CurrLevel) * (character.CurrLevel) * 90) / 20) + 57 + character.MaxMpPotential);
        }
        else
        {
            character.CurrLevel++;
            character.ExpToNextLevel = GetExpNeeded(character.CurrLevel);
            character.Strength = LevelUpStat(character.StrengthPotential, character.CurrLevel, character.Strength);
            character.Defense = LevelUpStat(character.DefensePotential, character.CurrLevel, character.Defense);
            character.Intelligence = LevelUpStat(character.IntelligencePotential, character.CurrLevel, character.Intelligence);
            character.Will = LevelUpStat(character.WillPotential, character.CurrLevel, character.Will);
            character.Speed = LevelUpStat(character.SpeedPotential, character.CurrLevel, character.Speed);
            character.Agility = LevelUpStat(character.AgilityPotential, character.CurrLevel, character.Agility);
            character.MaxHp = LevelUpMaxHp(character);
            character.MaxMp = LevelUpMaxMp(character);
        }
    }

    public static int GetExpNeeded(int currentLevel)
    {
        if (currentLevel < maxLevel)
        {
            return (int)Math.Floor(Math.Pow((float)(currentLevel + 1), 3.2f));
        }
        else
        {
            return maxExp;
        }
    }
    
    //Provides a curve for stat growth for leveling up. Used Desmos to derive the curves.
    public static int LevelUpStat(int statPotential, int currLevel, int stat)
    {
        tempStatMod = stat - (int)Math.Floor(Math.Sqrt((200 + (statPotential * 10)) * ((currLevel - 1) + 8)) - 35);

        return (int)Math.Floor(Math.Sqrt((200 + (statPotential * 10)) * (currLevel + 8)) - 35) + tempStatMod;
    }

    public static int LevelUpMaxHp(BasePlayableCharacter character)
    {
        tempStatMod = character.MaxHp - (int)Math.Floor((60 + character.MaxHpPotential) * Math.Log10((character.CurrLevel - 1) + 7) + 177 - (50 * (character.CurrLevel - 1)));

        return (int)Math.Floor((60 + character.MaxHpPotential) * Math.Log10(character.CurrLevel + 7) + 177 - (50 * character.CurrLevel)) + tempStatMod;
    }

    public static int LevelUpMaxMp(BasePlayableCharacter character)
    {
        tempStatMod = character.MaxMp - (int)Math.Floor(((Math.Log10(character.CurrLevel - 1) * (character.CurrLevel - 1) * 90) / 20) + 57 + character.MaxMpPotential);

        return (int)Math.Floor(((Math.Log10(character.CurrLevel) * (character.CurrLevel) * 90) / 20) + 57 + character.MaxMpPotential) + tempStatMod;
    }
}
