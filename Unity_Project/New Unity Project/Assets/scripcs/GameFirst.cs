/***
 * 
 * 
 * 
 * 开发unity版本的石头剪刀布小游戏脚本控制
 * 
 * 
 * 
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//引入UI的命名空间

public class NewBehaviourScript : MonoBehaviour {

    public Image imageUser;       //用户的图片
    public Image computerUser;    //机器人的图片
    public Image winnerUser;      //显示胜负结果的图片
    public Text TextInfoTip;      //信息提示。



    int intUser = 0;
    //int intComputer = 0;
    //string strjudgeResult = null;
    //用户点击包
    public void UserClickBAOZI() {
        intUser = 0;
        ProcessCard();
    }
    //用户点击锤
    public void UserClickCHUI()
    {
        intUser = 1;
        ProcessCard();
    }
    //用户点击剪刀
    public void UserClickJIANDAO()
    {
        intUser = 2;
        ProcessCard();
    }

    //内部牌的逻辑处理
    public void ProcessCard() {
        //显示'用户出牌'
        switch (intUser) {
            case 0:
                imageUser.overrideSprite = Resources.Load("allUIImageVI/humen/剪刀", typeof(Image)) as Sprite;

                break;
            case 1:
                imageUser.overrideSprite = Resources.Load("allUIImageVI/humen/石头", typeof(Image)) as Sprite;

                break;
            case 2:
                imageUser.overrideSprite = Resources.Load("allUIImageVI/humen/布", typeof(Image)) as Sprite;

                break;

            default:
                break;
        }

        //机器出牌

        //内部牌处理

        //
    }
}
