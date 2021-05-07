﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFVoorbeeld
{
    /// <summary>
    /// Interaction logic for Oefening34.xaml
    /// </summary>
    public partial class Oefening34 : Window
    {
        public Oefening34()
        {
            InitializeComponent();
        }

        private void DeleteAllCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (sender as RichTextBox).Document.Blocks.Clear();
        }

        private void CopyCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Clipboard.SetText((sender as RichTextBox).Selection.Text, TextDataFormat.Rtf);
        }

        private void PasteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                (sender as RichTextBox).AppendText(Clipboard.GetText(TextDataFormat.Rtf));
            }
        }
        #region comments
        /*
         * ApplicationCommands.CancelPrint
ApplicationCommands.Close
ApplicationCommands.ContextMenu
ApplicationCommands.Copy
ApplicationCommands.CorrectionList
ApplicationCommands.Cut
ApplicationCommands.Delete
ApplicationCommands.Find
ApplicationCommands.Help
ApplicationCommands.New
ApplicationCommands.NotACommand
ApplicationCommands.Open
ApplicationCommands.Paste
ApplicationCommands.Print
ApplicationCommands.PrintPreview
ApplicationCommands.Properties
ApplicationCommands.Redo
ApplicationCommands.Replace
ApplicationCommands.Save
ApplicationCommands.SaveAs
ApplicationCommands.SelectAll
ApplicationCommands.Stop
ApplicationCommands.Undo
ComponentCommands.ExtendSelectionDown
ComponentCommands.ExtendSelectionLeft
ComponentCommands.ExtendSelectionRight
ComponentCommands.ExtendSelectionUp
ComponentCommands.MoveDown
ComponentCommands.MoveFocusBack
ComponentCommands.MoveFocusDown
ComponentCommands.MoveFocusForward
ComponentCommands.MoveFocusPageDown
ComponentCommands.MoveFocusPageUp
ComponentCommands.MoveFocusUp
ComponentCommands.MoveLeft
ComponentCommands.MoveRight
ComponentCommands.MoveToEnd
ComponentCommands.MoveToHome
ComponentCommands.MoveToPageDown
ComponentCommands.MoveToPageUp
ComponentCommands.MoveUp
ComponentCommands.ScrollByLine
ComponentCommands.ScrollPageDown
ComponentCommands.ScrollPageLeft
ComponentCommands.ScrollPageRight
ComponentCommands.ScrollPageUp
ComponentCommands.SelectToEnd
ComponentCommands.SelectToHome
ComponentCommands.SelectToPageDown
ComponentCommands.SelectToPageUp
DocumentViewer.FitToHeightCommand
DocumentViewer.FitToMaxPagesAcrossCommand
DocumentViewer.FitToWidthCommand
DocumentViewer.ViewThumbnailsCommand
EditingCommands.AlignCenter
EditingCommands.AlignJustify
EditingCommands.AlignLeft
EditingCommands.AlignRight
EditingCommands.Backspace
EditingCommands.CorrectSpellingError
EditingCommands.DecreaseFontSize
EditingCommands.DecreaseIndentation
EditingCommands.Delete
EditingCommands.DeleteNextWord
EditingCommands.DeletePreviousWord
EditingCommands.EnterLineBreak
EditingCommands.EnterParagraphBreak
EditingCommands.IgnoreSpellingError
EditingCommands.IncreaseFontSize
EditingCommands.IncreaseIndentation
EditingCommands.MoveDownByLine
EditingCommands.MoveDownByPage
EditingCommands.MoveDownByParagraph
EditingCommands.MoveLeftByCharacter
EditingCommands.MoveLeftByWord
EditingCommands.MoveRightByCharacter
EditingCommands.MoveRightByWord
EditingCommands.MoveToDocumentEnd
EditingCommands.MoveToDocumentStart
EditingCommands.MoveToLineEnd
EditingCommands.MoveToLineStart
EditingCommands.MoveUpByLine
EditingCommands.MoveUpByPage
EditingCommands.MoveUpByParagraph
EditingCommands.SelectDownByLine
EditingCommands.SelectDownByPage
EditingCommands.SelectDownByParagraph
EditingCommands.SelectLeftByCharacter
EditingCommands.SelectLeftByWord
EditingCommands.SelectRightByCharacter
EditingCommands.SelectRightByWord
EditingCommands.SelectToDocumentEnd
EditingCommands.SelectToDocumentStart
EditingCommands.SelectToLineEnd
EditingCommands.SelectToLineStart
EditingCommands.SelectUpByLine
EditingCommands.SelectUpByPage
EditingCommands.SelectUpByParagraph
EditingCommands.TabBackward
EditingCommands.TabForward
EditingCommands.ToggleBold
EditingCommands.ToggleBullets
EditingCommands.ToggleInsert
EditingCommands.ToggleItalic
EditingCommands.ToggleNumbering
EditingCommands.ToggleSubscript
EditingCommands.ToggleSuperscript
EditingCommands.ToggleUnderline
MediaCommands.BoostBass
MediaCommands.ChannelDown
MediaCommands.ChannelUp
MediaCommands.DecreaseBass
MediaCommands.DecreaseMicrophoneVolume
MediaCommands.DecreaseTreble
MediaCommands.DecreaseVolume
MediaCommands.FastForward
MediaCommands.IncreaseBass
MediaCommands.IncreaseMicrophoneVolume
MediaCommands.IncreaseTreble
MediaCommands.IncreaseVolume
MediaCommands.MuteMicrophoneVolume
MediaCommands.MuteVolume
MediaCommands.NextTrack
MediaCommands.Pause
MediaCommands.Play
MediaCommands.PreviousTrack
MediaCommands.Record
MediaCommands.Rewind
MediaCommands.Select
MediaCommands.Stop
MediaCommands.ToggleMicrophoneOnOff
MediaCommands.TogglePlayPause
NavigationCommands.BrowseBack
NavigationCommands.BrowseForward
NavigationCommands.BrowseHome
NavigationCommands.BrowseStop
NavigationCommands.DecreaseZoom
NavigationCommands.Favorites
NavigationCommands.FirstPage
NavigationCommands.GoToPage
NavigationCommands.IncreaseZoom
NavigationCommands.LastPage
NavigationCommands.NavigateJournal
NavigationCommands.NextPage
NavigationCommands.PreviousPage
NavigationCommands.Refresh
NavigationCommands.Search
NavigationCommands.Zoom
Slider.DecreaseLarge
Slider.DecreaseSmall
Slider.IncreaseLarge
Slider.IncreaseSmall
Slider.MaximizeValue
Slider.MinimizeValue
         */
        #endregion
    }
}