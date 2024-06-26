﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    partial class SdlKeyboard
    {
        private static readonly Dictionary<Scancode, Key> _keyMap = new()
        {
            { Scancode.ScancodeUnknown, Key.Unknown },
            { Scancode.ScancodeA, Key.A },
            { Scancode.ScancodeB, Key.B },
            { Scancode.ScancodeC, Key.C },
            { Scancode.ScancodeD, Key.D },
            { Scancode.ScancodeE, Key.E },
            { Scancode.ScancodeF, Key.F },
            { Scancode.ScancodeG, Key.G },
            { Scancode.ScancodeH, Key.H },
            { Scancode.ScancodeI, Key.I },
            { Scancode.ScancodeJ, Key.J },
            { Scancode.ScancodeK, Key.K },
            { Scancode.ScancodeL, Key.L },
            { Scancode.ScancodeM, Key.M },
            { Scancode.ScancodeN, Key.N },
            { Scancode.ScancodeO, Key.O },
            { Scancode.ScancodeP, Key.P },
            { Scancode.ScancodeQ, Key.Q },
            { Scancode.ScancodeR, Key.R },
            { Scancode.ScancodeS, Key.S },
            { Scancode.ScancodeT, Key.T },
            { Scancode.ScancodeU, Key.U },
            { Scancode.ScancodeV, Key.V },
            { Scancode.ScancodeW, Key.W },
            { Scancode.ScancodeX, Key.X },
            { Scancode.ScancodeY, Key.Y },
            { Scancode.ScancodeZ, Key.Z },
            { Scancode.Scancode1, Key.Number1 },
            { Scancode.Scancode2, Key.Number2 },
            { Scancode.Scancode3, Key.Number3 },
            { Scancode.Scancode4, Key.Number4 },
            { Scancode.Scancode5, Key.Number5 },
            { Scancode.Scancode6, Key.Number6 },
            { Scancode.Scancode7, Key.Number7 },
            { Scancode.Scancode8, Key.Number8 },
            { Scancode.Scancode9, Key.Number9 },
            { Scancode.Scancode0, Key.Number0 },
            { Scancode.ScancodeReturn, Key.Enter },
            { Scancode.ScancodeEscape, Key.Escape },
            { Scancode.ScancodeBackspace, Key.Backspace },
            { Scancode.ScancodeTab, Key.Tab },
            { Scancode.ScancodeSpace, Key.Space },
            { Scancode.ScancodeMinus, Key.Minus },
            { Scancode.ScancodeEquals, Key.Equal },
            { Scancode.ScancodeLeftbracket, Key.LeftBracket },
            { Scancode.ScancodeRightbracket, Key.RightBracket },
            { Scancode.ScancodeBackslash, Key.BackSlash },
            //{Scancode.ScancodeNonushash, /* no mapping */},
            { Scancode.ScancodeSemicolon, Key.Semicolon },
            { Scancode.ScancodeApostrophe, Key.Apostrophe },
            { Scancode.ScancodeGrave, Key.GraveAccent },
            { Scancode.ScancodeComma, Key.Comma },
            { Scancode.ScancodePeriod, Key.Period },
            { Scancode.ScancodeSlash, Key.Slash },
            { Scancode.ScancodeCapslock, Key.CapsLock },
            { Scancode.ScancodeF1, Key.F1 },
            { Scancode.ScancodeF2, Key.F2 },
            { Scancode.ScancodeF3, Key.F3 },
            { Scancode.ScancodeF4, Key.F4 },
            { Scancode.ScancodeF5, Key.F5 },
            { Scancode.ScancodeF6, Key.F6 },
            { Scancode.ScancodeF7, Key.F7 },
            { Scancode.ScancodeF8, Key.F8 },
            { Scancode.ScancodeF9, Key.F9 },
            { Scancode.ScancodeF10, Key.F10 },
            { Scancode.ScancodeF11, Key.F11 },
            { Scancode.ScancodeF12, Key.F12 },
            { Scancode.ScancodePrintscreen, Key.PrintScreen },
            { Scancode.ScancodeScrolllock, Key.ScrollLock },
            { Scancode.ScancodePause, Key.Pause },
            { Scancode.ScancodeInsert, Key.Insert },
            { Scancode.ScancodeHome, Key.Home },
            { Scancode.ScancodePageup, Key.PageUp },
            { Scancode.ScancodeDelete, Key.Delete },
            { Scancode.ScancodeEnd, Key.End },
            { Scancode.ScancodePagedown, Key.PageDown },
            { Scancode.ScancodeRight, Key.Right },
            { Scancode.ScancodeLeft, Key.Left },
            { Scancode.ScancodeDown, Key.Down },
            { Scancode.ScancodeUp, Key.Up },
            { Scancode.ScancodeNumlockclear, Key.NumLock },
            { Scancode.ScancodeKPDivide, Key.KeypadDivide },
            { Scancode.ScancodeKPMultiply, Key.KeypadMultiply },
            { Scancode.ScancodeKPMinus, Key.KeypadSubtract },
            { Scancode.ScancodeKPPlus, Key.KeypadAdd },
            { Scancode.ScancodeKPEnter, Key.KeypadEnter },
            { Scancode.ScancodeKP1, Key.Keypad1 },
            { Scancode.ScancodeKP2, Key.Keypad2 },
            { Scancode.ScancodeKP3, Key.Keypad3 },
            { Scancode.ScancodeKP4, Key.Keypad4 },
            { Scancode.ScancodeKP5, Key.Keypad5 },
            { Scancode.ScancodeKP6, Key.Keypad6 },
            { Scancode.ScancodeKP7, Key.Keypad7 },
            { Scancode.ScancodeKP8, Key.Keypad8 },
            { Scancode.ScancodeKP9, Key.Keypad9 },
            { Scancode.ScancodeKP0, Key.Keypad0 },
            { Scancode.ScancodeKPPeriod, Key.KeypadDecimal },
            { Scancode.ScancodeNonusbackslash, Key.BackSlash },
            { Scancode.ScancodeApplication, Key.Menu },
            //{Scancode.ScancodePower, /* no mapping */},
            { Scancode.ScancodeKPEquals, Key.KeypadEqual },
            { Scancode.ScancodeF13, Key.F13 },
            { Scancode.ScancodeF14, Key.F14 },
            { Scancode.ScancodeF15, Key.F15 },
            { Scancode.ScancodeF16, Key.F16 },
            { Scancode.ScancodeF17, Key.F17 },
            { Scancode.ScancodeF18, Key.F18 },
            { Scancode.ScancodeF19, Key.F19 },
            { Scancode.ScancodeF20, Key.F20 },
            { Scancode.ScancodeF21, Key.F21 },
            { Scancode.ScancodeF22, Key.F22 },
            { Scancode.ScancodeF23, Key.F23 },
            { Scancode.ScancodeF24, Key.F24 },
            // { Scancode.ScancodeExecute, /* no mapping */ },
            // { Scancode.ScancodeHelp, /* no mapping */ },
            { Scancode.ScancodeMenu, Key.Menu },
            // { Scancode.ScancodeSelect, /* no mapping */ },
            // { Scancode.ScancodeStop, /* no mapping */ },
            // { Scancode.ScancodeAgain, /* no mapping */ },
            // { Scancode.ScancodeUndo, /* no mapping */ },
            // { Scancode.ScancodeCut, /* no mapping */ },
            // { Scancode.ScancodeCopy, /* no mapping */ },
            // { Scancode.ScancodePaste, /* no mapping */ },
            // { Scancode.ScancodeFind, /* no mapping */ },
            // { Scancode.ScancodeMute, /* no mapping */ },
            // { Scancode.ScancodeVolumeup, /* no mapping */ },
            // { Scancode.ScancodeVolumedown, /* no mapping */ },
            // { Scancode.ScancodeKPComma, /* no mapping */ },
            // { Scancode.ScancodeKPEqualsas400, /* no mapping */ },
            // { Scancode.ScancodeInternational1, /* no mapping */ },
            // { Scancode.ScancodeInternational2, /* no mapping */ },
            // { Scancode.ScancodeInternational3, /* no mapping */ },
            // { Scancode.ScancodeInternational4, /* no mapping */ },
            // { Scancode.ScancodeInternational5, /* no mapping */ },
            // { Scancode.ScancodeInternational6, /* no mapping */ },
            // { Scancode.ScancodeInternational7, /* no mapping */ },
            // { Scancode.ScancodeInternational8, /* no mapping */ },
            // { Scancode.ScancodeInternational9, /* no mapping */ },
            // { Scancode.ScancodeLang1, /* no mapping */ },
            // { Scancode.ScancodeLang2, /* no mapping */ },
            // { Scancode.ScancodeLang3, /* no mapping */ },
            // { Scancode.ScancodeLang4, /* no mapping */ },
            // { Scancode.ScancodeLang5, /* no mapping */ },
            // { Scancode.ScancodeLang6, /* no mapping */ },
            // { Scancode.ScancodeLang7, /* no mapping */ },
            // { Scancode.ScancodeLang8, /* no mapping */ },
            // { Scancode.ScancodeLang9, /* no mapping */ },
            // { Scancode.ScancodeAlterase, /* no mapping */ },
            // { Scancode.ScancodeSysreq, /* no mapping */ },
            // { Scancode.ScancodeCancel, /* no mapping */ },
            // { Scancode.ScancodeClear, /* no mapping */ },
            // { Scancode.ScancodePrior, /* no mapping */ },
            { Scancode.ScancodeReturn2, Key.Enter },
            // { Scancode.ScancodeSeparator, /* no mapping */ },
            // { Scancode.ScancodeOut, /* no mapping */ },
            // { Scancode.ScancodeOper, /* no mapping */ },
            // { Scancode.ScancodeClearagain, /* no mapping */ },
            // { Scancode.ScancodeCrsel, /* no mapping */ },
            // { Scancode.ScancodeExsel, /* no mapping */ },
            // { Scancode.ScancodeKP00, /* no mapping */ },
            // { Scancode.ScancodeKP000, /* no mapping */ },
            // { Scancode.ScancodeThousandsseparator, /* no mapping */ },
            // { Scancode.ScancodeDecimalseparator, /* no mapping */ },
            // { Scancode.ScancodeCurrencyunit, /* no mapping */ },
            // { Scancode.ScancodeCurrencysubunit, /* no mapping */ },
            // { Scancode.ScancodeKPLeftparen, /* no mapping */ },
            // { Scancode.ScancodeKPRightparen, /* no mapping */ },
            // { Scancode.ScancodeKPLeftbrace, /* no mapping */ },
            // { Scancode.ScancodeKPRightbrace, /* no mapping */ },
            // { Scancode.ScancodeKPTab, /* no mapping */ },
            // { Scancode.ScancodeKPBackspace, /* no mapping */ },
            // { Scancode.ScancodeKPA, /* no mapping */ },
            // { Scancode.ScancodeKPB, /* no mapping */ },
            // { Scancode.ScancodeKPC, /* no mapping */ },
            // { Scancode.ScancodeKPD, /* no mapping */ },
            // { Scancode.ScancodeKPE, /* no mapping */ },
            // { Scancode.ScancodeKPF, /* no mapping */ },
            // { Scancode.ScancodeKPXor, /* no mapping */ },
            // { Scancode.ScancodeKPPower, /* no mapping */ },
            // { Scancode.ScancodeKPPercent, /* no mapping */ },
            // { Scancode.ScancodeKPLess, /* no mapping */ },
            // { Scancode.ScancodeKPGreater, /* no mapping */ },
            // { Scancode.ScancodeKPAmpersand, /* no mapping */ },
            // { Scancode.ScancodeKPDblampersand, /* no mapping */ },
            // { Scancode.ScancodeKPVerticalbar, /* no mapping */ },
            // { Scancode.ScancodeKPDblverticalbar, /* no mapping */ },
            // { Scancode.ScancodeKPColon, /* no mapping */ },
            // { Scancode.ScancodeKPHash, /* no mapping */ },
            // { Scancode.ScancodeKPSpace, /* no mapping */ },
            // { Scancode.ScancodeKPAT, /* no mapping */ },
            // { Scancode.ScancodeKPExclam, /* no mapping */ },
            // { Scancode.ScancodeKPMemstore, /* no mapping */ },
            // { Scancode.ScancodeKPMemrecall, /* no mapping */ },
            // { Scancode.ScancodeKPMemclear, /* no mapping */ },
            // { Scancode.ScancodeKPMemadd, /* no mapping */ },
            // { Scancode.ScancodeKPMemsubtract, /* no mapping */ },
            // { Scancode.ScancodeKPMemmultiply, /* no mapping */ },
            // { Scancode.ScancodeKPMemdivide, /* no mapping */ },
            // { Scancode.ScancodeKPPlusminus, /* no mapping */ },
            // { Scancode.ScancodeKPClear, /* no mapping */ },
            // { Scancode.ScancodeKPClearentry, /* no mapping */ },
            // { Scancode.ScancodeKPBinary, /* no mapping */ },
            // { Scancode.ScancodeKPOctal, /* no mapping */ },
            // { Scancode.ScancodeKPDecimal, /* no mapping */ },
            // { Scancode.ScancodeKPHexadecimal, /* no mapping */ },
            { Scancode.ScancodeLctrl, Key.ControlLeft },
            { Scancode.ScancodeLshift, Key.ShiftLeft },
            { Scancode.ScancodeLalt, Key.AltLeft },
            { Scancode.ScancodeLgui, Key.SuperLeft },
            { Scancode.ScancodeRctrl, Key.ControlRight },
            { Scancode.ScancodeRshift, Key.ShiftRight },
            { Scancode.ScancodeRalt, Key.AltRight },
            { Scancode.ScancodeRgui, Key.SuperRight },
            // { Scancode.ScancodeMode, /* no mapping */ },
            // { Scancode.ScancodeAudionext, /* no mapping */ },
            // { Scancode.ScancodeAudioprev, /* no mapping */ },
            // { Scancode.ScancodeAudiostop, /* no mapping */ },
            // { Scancode.ScancodeAudioplay, /* no mapping */ },
            // { Scancode.ScancodeAudiomute, /* no mapping */ },
            // { Scancode.ScancodeMediaselect, /* no mapping */ },
            // { Scancode.ScancodeWww, /* no mapping */ },
            // { Scancode.ScancodeMail, /* no mapping */ },
            // { Scancode.ScancodeCalculator, /* no mapping */ },
            // { Scancode.ScancodeComputer, /* no mapping */ },
            // { Scancode.ScancodeACSearch, /* no mapping */ },
            // { Scancode.ScancodeACHome, /* no mapping */ },
            // { Scancode.ScancodeACBack, /* no mapping */ },
            // { Scancode.ScancodeACForward, /* no mapping */ },
            // { Scancode.ScancodeACStop, /* no mapping */ },
            // { Scancode.ScancodeACRefresh, /* no mapping */ },
            // { Scancode.ScancodeACBookmarks, /* no mapping */ },
            // { Scancode.ScancodeBrightnessdown, /* no mapping */ },
            // { Scancode.ScancodeBrightnessup, /* no mapping */ },
            // { Scancode.ScancodeDisplayswitch, /* no mapping */ },
            // { Scancode.ScancodeKbdillumtoggle, /* no mapping */ },
            // { Scancode.ScancodeKbdillumdown, /* no mapping */ },
            // { Scancode.ScancodeKbdillumup, /* no mapping */ },
            // { Scancode.ScancodeEject, /* no mapping */ },
            // { Scancode.ScancodeSleep, /* no mapping */ },
            // { Scancode.ScancodeApp1, /* no mapping */ },
            // { Scancode.ScancodeApp2, /* no mapping */ },
            // { Scancode.ScancodeAudiorewind, /* no mapping */ },
            // { Scancode.ScancodeAudiofastforward, /* no mapping */ },
        };
    }
}
