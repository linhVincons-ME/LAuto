using System;

// Token: 0x020002D9 RID: 729
internal class Class512
{
	// Token: 0x0600267E RID: 9854 RVA: 0x0001A247 File Offset: 0x00018447
	public Class512(Class106 class106_1)
	{
		this.class106_0 = class106_1;
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x0001A263 File Offset: 0x00018463
	public void method_0()
	{
		this.method_48("setmetatable(_G, {__index = Pet_Env }); PETNUM = -1; PETPOINT = -1; for i=1, 10 do if Pet:IsPresent(i-1) and Pet:GetIsFighting(i-1) then PETNUM = i -1; strName = Pet:GetPotential(i -1); PETPOINT = tonumber(strName); end end if PETPOINT ~= -1 then Pet:Add_Attribute(PETNUM ,PETPOINT ,0, 0, 0, 0); end");
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x0001A270 File Offset: 0x00018470
	public void method_1()
	{
		this.method_48("setmetatable(_G, {__index = Pet_Env }); PETNUM = -1; PETPOINT = -1; for i=1, 10 do if Pet:IsPresent(i-1) and Pet:GetIsFighting(i-1) then PETNUM = i -1; strName = Pet:GetPotential(i -1); PETPOINT = tonumber(strName); end end if PETPOINT ~= -1 then Pet:Add_Attribute(PETNUM ,0 , PETPOINT, 0, 0, 0); end");
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x0001A27D File Offset: 0x0001847D
	public void method_2()
	{
		this.method_48("setmetatable(_G, {__index = Pet_Env }); PETNUM = -1; PETPOINT = -1; for i=1, 10 do if Pet:IsPresent(i-1) and Pet:GetIsFighting(i-1) then PETNUM = i -1; strName = Pet:GetPotential(i -1); PETPOINT = tonumber(strName); end end if PETPOINT ~= -1 then Pet:Add_Attribute(PETNUM ,0 , 0, 0, PETPOINT, 0); end");
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x0001A28A File Offset: 0x0001848A
	public void method_3()
	{
		this.method_48("setmetatable(_G, {__index = Pet_Env }); PETNUM = -1; PETPOINT = -1; for i=1, 10 do if Pet:IsPresent(i-1) and Pet:GetIsFighting(i-1) then PETNUM = i -1; strName = Pet:GetPotential(i -1); PETPOINT = tonumber(strName); end end if PETPOINT ~= -1 then Pet:Add_Attribute(PETNUM ,0 , 0, PETPOINT, 0, 0); end");
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x0001A297 File Offset: 0x00018497
	public void method_4(int int_1)
	{
		this.method_48("Pneuma:SmeltPneumaItem(" + int_1.ToString() + ")");
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x0001A2B5 File Offset: 0x000184B5
	public void method_5(int int_1)
	{
		this.method_48(string.Format("PlayerPackage:UseItem({0});", int_1));
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x0001A2CD File Offset: 0x000184CD
	public void method_6()
	{
		this.method_48("setmetatable(_G, {__index = ChatFrame_Env}); this:Hide();");
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x0001A2DA File Offset: 0x000184DA
	public void method_7()
	{
		this.method_48("setmetatable(_G, {__index = TurnPlate_Env}); if this ~= nil and this:IsVisible() then TurnPlate_Click_SetTimer(0); TurnPlate_ChouJiang(); TurnPlate_LingJiang(); end");
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x0001A2E7 File Offset: 0x000184E7
	public void method_8()
	{
		this.method_48("SelectTargetOfTarget();");
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x0001A2F4 File Offset: 0x000184F4
	public void method_9()
	{
		this.method_48("Player:TeamFrame_AskTeamFollow();");
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x0001A301 File Offset: 0x00018501
	public void method_10()
	{
		this.method_48("Pet:HandlePetMenuItemSelf('feed');");
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x0001A30E File Offset: 0x0001850E
	public void method_11()
	{
		this.method_48("Clear_XSCRIPT()\n                                                Set_XSCRIPT_Function_Name('FiveElementsCohesion')\n                                                Set_XSCRIPT_ScriptID(880039)\n                                                Set_XSCRIPT_Parameter(0, -1)\n                                                Set_XSCRIPT_Parameter(1, 0)\n                                                Set_XSCRIPT_ParamCount(2)\n                                                Send_XSCRIPT()");
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x0001A31B File Offset: 0x0001851B
	public void method_12()
	{
		this.method_48("Clear_XSCRIPT();\n\t\t\tSet_XSCRIPT_Function_Name('DoBless_WithFJL' );\n\t\t\tSet_XSCRIPT_ScriptID( 890509 );\n\t\t\tSet_XSCRIPT_Parameter( 0, 1 );\n\t\t\tSet_XSCRIPT_ParamCount( 1 );\n\t\t\tSend_XSCRIPT();");
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x0001A328 File Offset: 0x00018528
	public void method_13()
	{
		this.method_48("Clear_XSCRIPT()\n                     Set_XSCRIPT_Function_Name('MartialLastDayMonsterReward')\n                     Set_XSCRIPT_ScriptID(507010)\n                     Set_XSCRIPT_Parameter(0, 2)\n                     Set_XSCRIPT_Parameter(1, 0)\n                     Set_XSCRIPT_ParamCount(2)\n                     Send_XSCRIPT()");
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x0001A335 File Offset: 0x00018535
	public void method_14()
	{
		this.method_48("Clear_XSCRIPT();\n                         Set_XSCRIPT_Function_Name('GetExp_ByYuanBao');\n                         Set_XSCRIPT_ScriptID(892659);\n                         Set_XSCRIPT_Parameter(0, 0)\n                         Set_XSCRIPT_Parameter(1, 0)\n                         Set_XSCRIPT_ParamCount(2);\n                         Send_XSCRIPT(); ");
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x0001A2CD File Offset: 0x000184CD
	public void method_15()
	{
		this.method_48("setmetatable(_G, {__index = ChatFrame_Env}); this:Hide();");
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x0001A342 File Offset: 0x00018542
	public void method_16()
	{
		this.method_48("setmetatable(_G, {__index = ChatFrame_Env}); this:Show();");
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x0001A34F File Offset: 0x0001854F
	public void method_17()
	{
		this.method_48("Player:SendReliveMessage_Relive();");
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x0001A35C File Offset: 0x0001855C
	public void method_18()
	{
		this.method_48("setmetatable(_G, {__index = Bank_Env}); this:Hide(); setmetatable(_G, {__index = BigBank_Env}); if this ~= nil then this:Hide(); end");
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x0001A369 File Offset: 0x00018569
	public void method_19()
	{
		this.method_48((this.class106_0.Class502_0.Int32_5 == 1) ? "if Player:IsInTeam() == 1 then Player:LeaveTeam() elseif Player:IsInRaid() == 1 then Player:LeaveRiad() end" : "if Player:IsInTeam() == 1 then Player:LeaveTeam() end");
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x0001A390 File Offset: 0x00018590
	public void method_20(int int_1 = 1)
	{
		this.method_48(string.Format("QuestFrameMissionComplete({0});", int_1));
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x0001A3A8 File Offset: 0x000185A8
	public void method_21()
	{
		this.method_48("Player:CreateTeamSelf();");
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x0001A3B5 File Offset: 0x000185B5
	public void method_22(int int_1)
	{
		this.method_48(string.Format("setmetatable(_G, {{__index = LoginLogOn_Env}}); if this ~= nil and this:IsVisible() then LogOn_Region:SetCurrentSelect({0}); end", int_1));
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x0001A3CD File Offset: 0x000185CD
	public void method_23()
	{
		this.method_48("DataPool:ReConnect();");
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x0001A3DA File Offset: 0x000185DA
	public void method_24()
	{
		this.method_48("LogOn_ExitToSelectServer();");
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x0001A3E7 File Offset: 0x000185E7
	public void method_25()
	{
		this.method_48("PushEvent('TOGLE_MISSION_OUTLINE');");
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x0001A3F4 File Offset: 0x000185F4
	public void method_26()
	{
		if (this.class106_0.Class502_0.Int32_5 == 3)
		{
			this.method_48("EnterQuitWait(1)");
			return;
		}
		this.method_48("AskRet2SelServer();");
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x0001A3A8 File Offset: 0x000185A8
	public void method_27()
	{
		this.method_48("Player:CreateTeamSelf();");
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x0001A420 File Offset: 0x00018620
	public void method_28()
	{
		this.method_48("OpenWindow('MissionTrack');");
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x0001A42D File Offset: 0x0001862D
	public void method_29()
	{
		this.method_48("GameProduceLogin:ExitToSelectServer();");
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x0001A43A File Offset: 0x0001863A
	public void method_30()
	{
		this.method_48("setmetatable(_G, {__index = TextValidate_Env}); TextValidate_BtnCloseClick(); setmetatable(_G, {__index = LoginOverTime_Env}); LoginOverTime_Bn1Click();");
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x0001A447 File Offset: 0x00018647
	public void method_31()
	{
		this.method_48("setmetatable(_G, {__index = LoginSelectServerQuest_Env}); if this ~= nil and this:IsVisible() then SelectServerQuest_Bn1Click(); end");
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x0011DA3C File Offset: 0x0011BC3C
	public void method_32(int int_1, int int_2)
	{
		Class534.PostMessage(this.class106_0.IntPtr_0, Class226.Int32_20, (long)int_1, 57L);
		Class534.PostMessage(this.class106_0.IntPtr_0, Class226.Int32_20, (long)int_2, 58L);
		Class534.PostMessage(this.class106_0.IntPtr_0, Class226.Int32_20, 52L, 105L);
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x0001A454 File Offset: 0x00018654
	public void method_33()
	{
		this.method_48("PushEvent('TOGGLE_YUANBAOSHOP');");
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x0001A461 File Offset: 0x00018661
	public void method_34()
	{
		this.class106_0.method_375("setmetatable(_G, {__index = YuanbaoShop_Env}); this:Hide();", false);
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x0001A474 File Offset: 0x00018674
	public void method_35()
	{
		this.method_48("Player:SendReliveMessage_OutGhost();");
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x0011DAB4 File Offset: 0x0011BCB4
	public void method_36(string string_0)
	{
		string[] array = string_0.Split(new char[] { ',' });
		if (array.Length >= 2)
		{
			int num = array[0].smethod_26();
			int num2 = array[1].smethod_26();
			this.method_38((float)num, (float)num2);
		}
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x0001A481 File Offset: 0x00018681
	public void method_37()
	{
		this.method_48("EnterReconnect(true);");
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x0001A48E File Offset: 0x0001868E
	public void method_38(float float_0, float float_1)
	{
		this.method_48(string.Format("AutoRunToTarget({0},{1})", (int)Math.Round((double)float_0, 0, MidpointRounding.AwayFromZero), (int)Math.Round((double)float_1, 0, MidpointRounding.AwayFromZero)));
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x0001A4BE File Offset: 0x000186BE
	public void method_39(int int_1, int int_2 = 1)
	{
		this.method_48(string.Format("NpcShop:BulkBuyItem({0},{1},0)", int_1, int_2));
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x0001A4DC File Offset: 0x000186DC
	public void method_40(int int_1)
	{
		this.method_45();
		this.method_48(string.Format("local cnt = 0; while true do MissionId = DataPool:GetPlayerMission_Display(cnt,7); local name, content = DataPool:GetPlayerMission_Memo(cnt); if MissionId == {0} or DataPool:GetPlayerMission_Variable(cnt, 0) == 2  then PushDebugMessage(name); DataPool:Mission_Abnegate_Popup(cnt,DataPool:GetPlayerMission_Memo(cnt)); end cnt = cnt + 1; if cnt == 20 then return end end", int_1));
		this.method_50();
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x0001A500 File Offset: 0x00018700
	public void method_41(string string_0)
	{
		this.method_45();
		this.method_48("local cnt = 0; while true do local name, content = DataPool:GetPlayerMission_Memo(cnt); if string.find(name, '" + string_0.Trim() + "') or DataPool:GetPlayerMission_Variable(cnt, 0) == 2  then PushDebugMessage(name); DataPool:Mission_Abnegate_Popup(cnt,DataPool:GetPlayerMission_Memo(cnt)); end cnt = cnt + 1; if cnt == 20 then return end end");
		this.method_50();
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x0001A529 File Offset: 0x00018729
	public void method_42(string string_0)
	{
		this.method_41(string_0);
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x0001A532 File Offset: 0x00018732
	public void method_43(string string_0, string string_1)
	{
		this.method_48(string.Concat(new string[] { "Talk:SendChatMessage('", string_0, "', '", string_1, "');" }));
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x0001A565 File Offset: 0x00018765
	public void method_44(int int_1 = 1)
	{
		this.method_48(string.Format("QuestFrameMissionContinue({0});", int_1));
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x0001A57D File Offset: 0x0001877D
	public void method_45()
	{
		this.method_48("PushEvent('TOGLE_MISSION');");
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x0001A58A File Offset: 0x0001878A
	public void method_46()
	{
		this.method_48("setmetatable(_G, {__index = QuestLog_Env}); this:Hide();");
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x0001A597 File Offset: 0x00018797
	public void method_47()
	{
		this.method_48("setmetatable(_G, {__index = QuestLog_Env}); this:Show();");
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x0001A5A4 File Offset: 0x000187A4
	public void method_48(string string_0)
	{
		this.class106_0.method_375(string_0, false);
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x0001A5B3 File Offset: 0x000187B3
	public void method_49()
	{
		this.class106_0.method_375("PlayerPackage:PackUpPacket(0); PlayerPackage:PackUpPacket(1); setmetatable(_G, {__index = Packet_Temporary_Env}); if this ~= nil then Packet_Temporary_CleanButtonClk(); end", false);
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x0001A5C6 File Offset: 0x000187C6
	public void method_50()
	{
		this.method_48("setmetatable(_G, {__index = MessageBox_Self_Env}); if this ~= nil and this:IsVisible() then MessageBox_Self_OK_Clicked(); end");
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x0001A5D3 File Offset: 0x000187D3
	public void method_51()
	{
		this.method_48("setmetatable(_G, { __index = MessageBox_Self2_Env}); if this ~= nil and this:IsVisible() then MessageBox_Self2_Ok_Clicked(); end");
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x0001A5E0 File Offset: 0x000187E0
	public void method_52()
	{
		this.method_48("setmetatable(_G, {__index = AcceptBox_Env}); if  this ~= nil and this:IsVisible() then AcceptBox_OK_Clicked(); end");
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x0001A5ED File Offset: 0x000187ED
	public void method_53()
	{
		this.method_48("QuestFrameAcceptClicked();");
	}

	// Token: 0x040019DB RID: 6619
	private readonly Class106 class106_0;

	// Token: 0x040019DC RID: 6620
	public int[] int_0 = new int[20];
}
