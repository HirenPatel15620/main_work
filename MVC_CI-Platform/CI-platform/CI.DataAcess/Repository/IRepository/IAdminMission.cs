﻿using CI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Repository.Repository.IRepository
{
    public interface IAdminMission
    {

        List<Models.Mission> GetAllMission();
        List<Models.MissionApplication> GetAllMissionApplication();
        MissionApplication GetMissionApplicationById(long id);
        bool DeclineUser(MissionApplication missionapplication);
        List<Models.Skill> GetAllSkil();
        Skill GetSkillById(long id);
        bool DeclineSkill(Skill skill);
        List<Models.MissionTheme> GetAllTheme();
        MissionTheme GetThemeById(long id);
        bool DeclineTheme(MissionTheme theme);
        bool AddTheme(MissionTheme theme);
    }
}
