using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _i;

// Token: 0x02000211 RID: 529
internal class Class347 : SortedDictionary<Keys, FCTBAction>
{
	// Token: 0x06001D37 RID: 7479 RVA: 0x000DEE10 File Offset: 0x000DD010
	public virtual void vmethod_0()
	{
		base[(Keys)131143] = FCTBAction.GoToDialog;
		base[(Keys)131142] = FCTBAction.FindDialog;
		base[(Keys)262214] = FCTBAction.FindChar;
		base[global::System.Windows.Forms.Keys.F3] = FCTBAction.FindNext;
		base[(Keys)131144] = FCTBAction.ReplaceDialog;
		base[(Keys)131139] = FCTBAction.Copy;
		base[(Keys)196675] = FCTBAction.CommentSelected;
		base[(Keys)131160] = FCTBAction.Cut;
		base[(Keys)131158] = FCTBAction.Paste;
		base[(Keys)131137] = FCTBAction.SelectAll;
		base[(Keys)131162] = FCTBAction.Undo;
		base[(Keys)131154] = FCTBAction.Redo;
		base[(Keys)131157] = FCTBAction.UpperCase;
		base[(Keys)196693] = FCTBAction.LowerCase;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.F17 | global::System.Windows.Forms.Keys.Control] = FCTBAction.NavigateBackward;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.F17 | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control] = FCTBAction.NavigateForward;
		base[(Keys)131138] = FCTBAction.BookmarkLine;
		base[(Keys)196674] = FCTBAction.UnbookmarkLine;
		base[(Keys)131150] = FCTBAction.GoNextBookmark;
		base[(Keys)196686] = FCTBAction.GoPrevBookmark;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Alt] = FCTBAction.Undo;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Control] = FCTBAction.ClearWordLeft;
		base[global::System.Windows.Forms.Keys.Insert] = FCTBAction.ReplaceMode;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.Copy;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.Paste;
		base[global::System.Windows.Forms.Keys.Delete] = FCTBAction.DeleteCharRight;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.ClearWordRight;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.Cut;
		base[global::System.Windows.Forms.Keys.Left] = FCTBAction.GoLeft;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoLeftWithSelection;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoWordLeft;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoWordLeftWithSelection;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Alt] = FCTBAction.GoLeft_ColumnSelectionMode;
		base[global::System.Windows.Forms.Keys.Right] = FCTBAction.GoRight;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoRightWithSelection;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoWordRight;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoWordRightWithSelection;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Alt] = FCTBAction.GoRight_ColumnSelectionMode;
		base[global::System.Windows.Forms.Keys.Up] = FCTBAction.GoUp;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoUpWithSelection;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Alt] = FCTBAction.GoUp_ColumnSelectionMode;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Alt] = FCTBAction.MoveSelectedLinesUp;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.ScrollUp;
		base[global::System.Windows.Forms.Keys.Down] = FCTBAction.GoDown;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoDownWithSelection;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Alt] = FCTBAction.GoDown_ColumnSelectionMode;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Alt] = FCTBAction.MoveSelectedLinesDown;
		base[global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.ScrollDown;
		base[global::System.Windows.Forms.Keys.Prior] = FCTBAction.GoPageUp;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoPageUpWithSelection;
		base[global::System.Windows.Forms.Keys.Next] = FCTBAction.GoPageDown;
		base[global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoPageDownWithSelection;
		base[global::System.Windows.Forms.Keys.Home] = FCTBAction.GoHome;
		base[global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoHomeWithSelection;
		base[global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoFirstLine;
		base[global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoFirstLineWithSelection;
		base[global::System.Windows.Forms.Keys.End] = FCTBAction.GoEnd;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift] = FCTBAction.GoEndWithSelection;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoLastLine;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift | global::System.Windows.Forms.Keys.Control] = FCTBAction.GoLastLineWithSelection;
		base[global::System.Windows.Forms.Keys.Escape] = FCTBAction.ClearHints;
		base[(Keys)131149] = FCTBAction.MacroRecord;
		base[(Keys)131141] = FCTBAction.MacroExecute;
		base[global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.AutocompleteMenu;
		base[global::System.Windows.Forms.Keys.Tab] = FCTBAction.IndentIncrease;
		base[global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Shift] = FCTBAction.IndentDecrease;
		base[(Keys)131181] = FCTBAction.ZoomOut;
		base[(Keys)131179] = FCTBAction.ZoomIn;
		base[global::System.Windows.Forms.Keys.ShiftKey | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control] = FCTBAction.ZoomNormal;
		base[(Keys)131145] = FCTBAction.AutoIndentChars;
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x000DF17C File Offset: 0x000DD37C
	public override string ToString()
	{
		CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
		Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
		StringBuilder stringBuilder = new StringBuilder();
		KeysConverter keysConverter = new KeysConverter();
		foreach (KeyValuePair<Keys, FCTBAction> keyValuePair in this)
		{
			stringBuilder.AppendFormat("{0}={1}, ", keysConverter.ConvertToString(keyValuePair.Key), keyValuePair.Value);
		}
		if (stringBuilder.Length > 1)
		{
			stringBuilder.Remove(stringBuilder.Length - 2, 2);
		}
		Thread.CurrentThread.CurrentUICulture = currentUICulture;
		return stringBuilder.ToString();
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x000DF240 File Offset: 0x000DD440
	public static Class347 smethod_0(string string_0)
	{
		Class347 @class = new Class347();
		@class.Clear();
		CultureInfo currentUICulture = Thread.CurrentThread.CurrentUICulture;
		Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
		KeysConverter keysConverter = new KeysConverter();
		string[] array = string_0.Split(new char[] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[] { '=' });
			Keys keys = (Keys)keysConverter.ConvertFromString(array2[0].Trim());
			FCTBAction fctbaction = (FCTBAction)Enum.Parse(typeof(FCTBAction), array2[1].Trim());
			@class[keys] = fctbaction;
		}
		Thread.CurrentThread.CurrentUICulture = currentUICulture;
		return @class;
	}
}
