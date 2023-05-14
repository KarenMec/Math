using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class S_Main1 : MonoBehaviour
{
    public Sprite Button_1, Button_2;
    public Text Text_Answer;
    public TextMeshProUGUI Text_Level;
    public int level;
    public Sprite Level_1, Level_2, Level_3, Level_4, Level_5, Level_6, Level_7, Level_8, Level_9, Level_10, Level_11, Level_12, Level_13, Level_14, Level_15, Level_16, Level_17, Level_18, Level_19, Level_20, Level_21, Level_22, Level_23, Level_24, Level_25, Level_26, Level_27, Level_28, Level_29, Level_30, Level_31, Level_32, Level_33, Level_34, Level_35, Level_36, Level_37, Level_38, Level_39, Level_40, Level_41, Level_42, Level_43, Level_44, Level_45, Level_46, Level_47, Level_48, Level_49, Level_50, Level_51, Level_52, Level_53, Level_54, Level_55, Level_56, Level_57, Level_58, Level_59, Level_60, Level_61, Level_62, Level_63, Level_64, Level_65, Level_66, Level_67, Level_68, Level_69, Level_70, Level_71, Level_72, Level_73, Level_74, Level_75, Level_76, Level_77, Level_78, Level_79, Level_80, Level_81, Level_82, Level_83, Level_84, Level_85, Level_86, Level_87, Level_88, Level_89, Level_90, Level_91, Level_92, Level_93, Level_94, Level_95, Level_96, Level_97, Level_98, Level_99, Level_100;
    public AudioSource audiosource;
    public AudioSource Error, OK;

    void Start()
    {
        level = (PlayerPrefs.GetInt("level_SL"));
        if (1 == 1)
        { print("211221112"); }
        if (level == 1)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_1; } // load level 1
        if (level == 2)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_2; } // load level 3
        if (level == 3)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_3; } // load level 4
        if (level == 4)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_4; } // load level 5
        if (level == 5)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_5; } // load level 6
        if (level == 6)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_6; } // load level 7
        if (level == 7)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_7; } // load level 8
        if (level == 8)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_8; } // load level 9
        if (level == 9)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_9; } // load level 10
        if (level == 10)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_10; } // load level 11
        if (level == 11)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_11; } // load level 12
        if (level == 12)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_12; } // load level 13
        if (level == 13)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_13; } // load level 14
        if (level == 14)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_14; } // load level 15
        if (level == 15)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_15; } // load level 16
        if (level == 16)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_16; } // load level 17
        if (level == 17)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_17; } // load level 18
        if (level == 18)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_18; } // load level 19
        if (level == 19)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_29; } // load level 20
        if (level == 20)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_20; } // load level 21
        if (level == 21)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_21; } // load level 22
        if (level == 22)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_22; } // load level 23
        if (level == 23)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_23; } // load level 24
        if (level == 24)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_24; } // load level 25
        if (level == 25)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_25; } // load level 26
        if (level == 26)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_26; } // load level 27
        if (level == 27)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_27; } // load level 28
        if (level == 28)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_28; } // load level 29
        if (level == 29)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_29; } // load level 30
        if (level == 30)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_30; } // load level 31
        if (level == 31)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_31; } // load level 32
        if (level == 32)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_32; } // load level 33
        if (level == 33)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_33; } // load level 34
        if (level == 34)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_34; } // load level 35
        if (level == 35)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_35; } // load level 36
        if (level == 36)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_36; } // load level 37
        if (level == 37)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_37; } // load level 38
        if (level == 38)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_38; } // load level 39
        if (level == 39)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_39; } // load level 40
        if (level == 40)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_40; } // load level 41
        if (level == 41)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_41; } // load level 42
        if (level == 42)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_42; } // load level 43
        if (level == 43)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_43; } // load level 44
        if (level == 44)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_44; } // load level 45
        if (level == 45)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_45; } // load level 46
        if (level == 46)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_46; } // load level 47
        if (level == 47)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_47; } // load level 48
        if (level == 48)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_48; } // load level 49
        if (level == 49)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_49; } // load level 50
        if (level == 50)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_50; } // load level 51
        if (level == 51)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_51; } // load level 52
        if (level == 52)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_52; } // load level 53
        if (level == 53)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_53; } // load level 54
        if (level == 54)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_54; } // load level 55
        if (level == 55)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_55; } // load level 56
        if (level == 56)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_56; } // load level 57
        if (level == 57)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_57; } // load level 58
        if (level == 58)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_58; } // load level 59
        if (level == 59)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_59; } // load level 60
        if (level == 60)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_60; } // load level 61
        if (level == 61)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_61; } // load level 62
        if (level == 62)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_62; } // load level 63
        if (level == 63)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_63; } // load level 64
        if (level == 64)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_64; } // load level 65
        if (level == 65)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_65; } // load level 66
        if (level == 66)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_66; } // load level 67
        if (level == 67)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_67; } // load level 68
        if (level == 68)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_68; } // load level 69
        if (level == 69)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_69; } // load level 70
        if (level == 70)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_70; } // load level 71
        if (level == 71)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_71; } // load level 72
        if (level == 72)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_72; } // load level 73
        if (level == 73)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_73; } // load level 74
        if (level == 74)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_74; } // load level 75
        if (level == 75)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_75; } // load level 76
        if (level == 76)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_76; } // load level 77
        if (level == 77)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_77; } // load level 78
        if (level == 78)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_78; } // load level 79
        if (level == 79)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_79; } // load level 80
        if (level == 80)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_80; } // load level 81
        if (level == 81)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_81; } // load level 82
        if (level == 82)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_82; } // load level 83
        if (level == 83)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_83; } // load level 84
        if (level == 84)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_84; } // load level 85
        if (level == 85)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_85; } // load level 86
        if (level == 86)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_86; } // load level 87
        if (level == 87)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_87; } // load level 88
        if (level == 88)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_88; } // load level 89
        if (level == 89)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_89; } // load level 90
        if (level == 90)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_90; } // load level 91
        if (level == 91)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_91; } // load level 92
        if (level == 92)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_92; } // load level 93
        if (level == 93)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_93; } // load level 94
        if (level == 94)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_94; } // load level 95
        if (level == 95)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_95; } // load level 96
        if (level == 96)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_96; } // load level 97
        if (level == 97)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_97; } // load level 98
        if (level == 98)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_98; } // load level 99
        if (level == 99)
        { GameObject.Find("Level").GetComponent<SpriteRenderer>().sprite = Level_99; }
    }
}
