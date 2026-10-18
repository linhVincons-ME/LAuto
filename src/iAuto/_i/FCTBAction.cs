using System;

namespace _i
{
	// Token: 0x02000212 RID: 530
	public enum FCTBAction
	{
		// Token: 0x0400120B RID: 4619
		None,
		// Token: 0x0400120C RID: 4620
		AutocompleteMenu,
		// Token: 0x0400120D RID: 4621
		AutoIndentChars,
		// Token: 0x0400120E RID: 4622
		BookmarkLine,
		// Token: 0x0400120F RID: 4623
		ClearHints,
		// Token: 0x04001210 RID: 4624
		ClearWordLeft,
		// Token: 0x04001211 RID: 4625
		ClearWordRight,
		// Token: 0x04001212 RID: 4626
		CommentSelected,
		// Token: 0x04001213 RID: 4627
		Copy,
		// Token: 0x04001214 RID: 4628
		Cut,
		// Token: 0x04001215 RID: 4629
		DeleteCharRight,
		// Token: 0x04001216 RID: 4630
		FindChar,
		// Token: 0x04001217 RID: 4631
		FindDialog,
		// Token: 0x04001218 RID: 4632
		FindNext,
		// Token: 0x04001219 RID: 4633
		GoDown,
		// Token: 0x0400121A RID: 4634
		GoDownWithSelection,
		// Token: 0x0400121B RID: 4635
		GoDown_ColumnSelectionMode,
		// Token: 0x0400121C RID: 4636
		GoEnd,
		// Token: 0x0400121D RID: 4637
		GoEndWithSelection,
		// Token: 0x0400121E RID: 4638
		GoFirstLine,
		// Token: 0x0400121F RID: 4639
		GoFirstLineWithSelection,
		// Token: 0x04001220 RID: 4640
		GoHome,
		// Token: 0x04001221 RID: 4641
		GoHomeWithSelection,
		// Token: 0x04001222 RID: 4642
		GoLastLine,
		// Token: 0x04001223 RID: 4643
		GoLastLineWithSelection,
		// Token: 0x04001224 RID: 4644
		GoLeft,
		// Token: 0x04001225 RID: 4645
		GoLeftWithSelection,
		// Token: 0x04001226 RID: 4646
		GoLeft_ColumnSelectionMode,
		// Token: 0x04001227 RID: 4647
		GoPageDown,
		// Token: 0x04001228 RID: 4648
		GoPageDownWithSelection,
		// Token: 0x04001229 RID: 4649
		GoPageUp,
		// Token: 0x0400122A RID: 4650
		GoPageUpWithSelection,
		// Token: 0x0400122B RID: 4651
		GoRight,
		// Token: 0x0400122C RID: 4652
		GoRightWithSelection,
		// Token: 0x0400122D RID: 4653
		GoRight_ColumnSelectionMode,
		// Token: 0x0400122E RID: 4654
		GoToDialog,
		// Token: 0x0400122F RID: 4655
		GoNextBookmark,
		// Token: 0x04001230 RID: 4656
		GoPrevBookmark,
		// Token: 0x04001231 RID: 4657
		GoUp,
		// Token: 0x04001232 RID: 4658
		GoUpWithSelection,
		// Token: 0x04001233 RID: 4659
		GoUp_ColumnSelectionMode,
		// Token: 0x04001234 RID: 4660
		GoWordLeft,
		// Token: 0x04001235 RID: 4661
		GoWordLeftWithSelection,
		// Token: 0x04001236 RID: 4662
		GoWordRight,
		// Token: 0x04001237 RID: 4663
		GoWordRightWithSelection,
		// Token: 0x04001238 RID: 4664
		IndentIncrease,
		// Token: 0x04001239 RID: 4665
		IndentDecrease,
		// Token: 0x0400123A RID: 4666
		LowerCase,
		// Token: 0x0400123B RID: 4667
		MacroExecute,
		// Token: 0x0400123C RID: 4668
		MacroRecord,
		// Token: 0x0400123D RID: 4669
		MoveSelectedLinesDown,
		// Token: 0x0400123E RID: 4670
		MoveSelectedLinesUp,
		// Token: 0x0400123F RID: 4671
		NavigateBackward,
		// Token: 0x04001240 RID: 4672
		NavigateForward,
		// Token: 0x04001241 RID: 4673
		Paste,
		// Token: 0x04001242 RID: 4674
		Redo,
		// Token: 0x04001243 RID: 4675
		ReplaceDialog,
		// Token: 0x04001244 RID: 4676
		ReplaceMode,
		// Token: 0x04001245 RID: 4677
		ScrollDown,
		// Token: 0x04001246 RID: 4678
		ScrollUp,
		// Token: 0x04001247 RID: 4679
		SelectAll,
		// Token: 0x04001248 RID: 4680
		UnbookmarkLine,
		// Token: 0x04001249 RID: 4681
		Undo,
		// Token: 0x0400124A RID: 4682
		UpperCase,
		// Token: 0x0400124B RID: 4683
		ZoomIn,
		// Token: 0x0400124C RID: 4684
		ZoomNormal,
		// Token: 0x0400124D RID: 4685
		ZoomOut,
		// Token: 0x0400124E RID: 4686
		CustomAction1,
		// Token: 0x0400124F RID: 4687
		CustomAction2,
		// Token: 0x04001250 RID: 4688
		CustomAction3,
		// Token: 0x04001251 RID: 4689
		CustomAction4,
		// Token: 0x04001252 RID: 4690
		CustomAction5,
		// Token: 0x04001253 RID: 4691
		CustomAction6,
		// Token: 0x04001254 RID: 4692
		CustomAction7,
		// Token: 0x04001255 RID: 4693
		CustomAction8,
		// Token: 0x04001256 RID: 4694
		CustomAction9,
		// Token: 0x04001257 RID: 4695
		CustomAction10,
		// Token: 0x04001258 RID: 4696
		CustomAction11,
		// Token: 0x04001259 RID: 4697
		CustomAction12,
		// Token: 0x0400125A RID: 4698
		CustomAction13,
		// Token: 0x0400125B RID: 4699
		CustomAction14,
		// Token: 0x0400125C RID: 4700
		CustomAction15,
		// Token: 0x0400125D RID: 4701
		CustomAction16,
		// Token: 0x0400125E RID: 4702
		CustomAction17,
		// Token: 0x0400125F RID: 4703
		CustomAction18,
		// Token: 0x04001260 RID: 4704
		CustomAction19,
		// Token: 0x04001261 RID: 4705
		CustomAction20
	}
}
