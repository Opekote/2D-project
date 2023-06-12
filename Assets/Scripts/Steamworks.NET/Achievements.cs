using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;
public class Achievements : MonoBehaviour
{
    public CGameID m_GameID; // переменнные для инициализации приложения
    public AppId_t appID; // переменнные для инициализации приложения

    void Start()
    {
        appID = SteamUtils.GetAppID();
        m_GameID = new CGameID(SteamUtils.GetAppID()); // инициализация приложения
        DOST(); // даём ачивку при старте
    }
        
    void DOST()
    {
        SteamUserStats.SetAchievement("NEW_ACHIEVEMENT_2_0"); // даём достижение, где CD_start - название достижения, прописанное на сайте Воркса
        SteamUserStats.StoreStats(); // сохраняем статистику
    }
}
