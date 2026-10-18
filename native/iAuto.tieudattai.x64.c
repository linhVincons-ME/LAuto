// Decompiled by Ghidra from iAuto.tieudattai.dll

// ===== FUN_180001000 @ 180001000 =====

void FUN_180001000(void)

{
  DAT_180004698 = RegisterWindowMessageW(L"WM_SIMPLE_HOOK_WRITE");
  return;
}



// ===== FUN_180001020 @ 180001020 =====

void FUN_180001020(void)

{
  DAT_1800046a0 = GetModuleHandleW((LPCWSTR)0x0);
  return;
}



// ===== FUN_180001040 @ 180001040 =====

undefined8 FUN_180001040(HMODULE param_1,int param_2)

{
  BOOL BVar1;
  
  if (param_2 == 1) {
    DAT_180004680 = param_1;
    DisableThreadLibraryCalls(param_1);
    return 1;
  }
  if (param_2 == 0) {
    BVar1 = IsWindow(DAT_180004690);
    if ((BVar1 != 0) && ((int)DAT_180004688 != 0)) {
      BVar1 = IsWindow(DAT_180004690);
      if (BVar1 != 0) {
        UnhookWindowsHookEx(DAT_180004688);
        DAT_180004690 = (HWND)0x0;
        DAT_180004688 = (HHOOK)0x0;
      }
    }
  }
  return 1;
}



// ===== GetMSG @ 1800010c0 =====

undefined4 GetMSG(void)

{
                    /* 0x10c0  1  GetMSG */
  return DAT_180004698;
}



// ===== SetHook @ 1800010d0 =====

undefined8 SetHook(HWND param_1)

{
  BOOL BVar1;
  DWORD dwThreadId;
  
                    /* 0x10d0  2  SetHook */
  BVar1 = IsWindow(param_1);
  if (BVar1 != 0) {
    dwThreadId = GetWindowThreadProcessId(param_1,(LPDWORD)0x0);
    DAT_180004688 = SetWindowsHookExW(3,FUN_180001170,DAT_180004680,dwThreadId);
    if (DAT_180004688 != (HHOOK)0x0) {
      DAT_180004690 = param_1;
      return 1;
    }
  }
  return 0;
}



// ===== UnHook @ 180001130 =====

void UnHook(HWND param_1)

{
  BOOL BVar1;
  
                    /* 0x1130  3  UnHook */
  BVar1 = IsWindow(param_1);
  if (BVar1 == 0) {
    return;
  }
  UnhookWindowsHookEx(DAT_180004688);
  DAT_180004690 = 0;
  DAT_180004688 = (HHOOK)0x0;
  return;
}



// ===== FUN_180001170 @ 180001170 =====

undefined8 FUN_180001170(int param_1,undefined8 param_2,longlong param_3)

{
  int iVar1;
  undefined4 uVar2;
  longlong *plVar3;
  undefined8 *puVar4;
  longlong *plVar5;
  longlong lVar6;
  HMODULE pHVar7;
  undefined8 uVar8;
  float fVar9;
  
  if ((-1 < param_1) && (*(int *)(param_3 + 8) == DAT_180004698)) {
    if ((*(longlong *)(param_3 + 0x18) == 100) &&
       (plVar3 = *(longlong **)(DAT_1800046a0 + 0x729d40), plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0x78))(plVar3,*(undefined4 *)(param_3 + 0x10),1);
    }
    if ((*(longlong *)(param_3 + 0x18) == 0x6e) &&
       (plVar3 = *(longlong **)(DAT_1800046a0 + 0x729d40), plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0xf8))(plVar3,*(undefined4 *)(param_3 + 0x10),0);
    }
    if (*(longlong *)(param_3 + 0x18) == 0x68) {
      uVar8 = *(undefined8 *)(param_3 + 0x10);
      if (*(longlong **)(DAT_1800046a0 + 0x72cb78) != (longlong *)0x0) {
        puVar4 = (undefined8 *)(**(code **)(**(longlong **)(DAT_1800046a0 + 0x72cb78) + 0x78))();
        (**(code **)(DAT_1800046a0 + 0x5094d8))(*puVar4,uVar8);
      }
    }
    if (*(longlong *)(param_3 + 0x18) == 0x66) {
      if (((*(longlong *)(DAT_1800046a0 + 0x72c9e8) != 0) &&
          (lVar6 = *(longlong *)(*(longlong *)(DAT_1800046a0 + 0x72c9e8) + 0x10), lVar6 != 0)) &&
         (lVar6 = *(longlong *)(lVar6 + 0x1c0), lVar6 != 0)) {
        iVar1 = *(int *)(param_3 + 0x10);
        fVar9 = (float)iVar1;
        (*(code *)(DAT_1800046a0 + 0xe5a80))(lVar6,iVar1,iVar1,DAT_180004678,fVar9,fVar9,fVar9);
      }
    }
    if (*(longlong *)(param_3 + 0x18) == 0x6d) {
      plVar3 = *(longlong **)(param_3 + 0x10);
      if (*(longlong **)(DAT_1800046a0 + 0x72cb78) != (longlong *)0x0) {
        plVar5 = (longlong *)(**(code **)(**(longlong **)(DAT_1800046a0 + 0x72cb78) + 0x78))();
        if ((plVar5 != (longlong *)0x0) && (*plVar5 != 0)) {
          lVar6 = (**(code **)(DAT_1800046a0 + 0x5094d0))(*plVar5,0xffffffff);
          if (lVar6 != 0) {
            *plVar3 = lVar6;
          }
        }
      }
    }
    if ((*(longlong *)(param_3 + 0x18) == 0x6a) &&
       (plVar3 = *(longlong **)(DAT_1800046a0 + 0x729d40), plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0x100))(plVar3,*(undefined4 *)(param_3 + 0x10));
    }
    if ((*(longlong *)(param_3 + 0x18) == 0x6b) &&
       (plVar3 = *(longlong **)(DAT_1800046a0 + 0x729d40), plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0x108))(plVar3,*(undefined8 *)(param_3 + 0x10));
    }
    lVar6 = DAT_1800046a0;
    plVar3 = (longlong *)(param_3 + 0x10);
    if (*(longlong *)(param_3 + 0x18) == 0x6c) {
      uVar2 = *(undefined4 *)plVar3;
      *(undefined4 *)(*(longlong *)(DAT_1800046a0 + 0x724298) + 0x68228) = 2;
      *(undefined4 *)(*(longlong *)(lVar6 + 0x724298) + 0x6822c) = uVar2;
      (*(code *)(lVar6 + 0x1ce710))();
    }
    if (*(longlong *)(param_3 + 0x18) == 0x35) {
      DAT_180004678 = *(undefined4 *)plVar3;
    }
    else if (*(longlong *)(param_3 + 0x18) == 0x72) {
      lVar6 = *plVar3;
      pHVar7 = GetModuleHandleW((LPCWSTR)0x0);
      (*(code *)(pHVar7 + 0xc3e84))(*(undefined8 *)(pHVar7 + 0x1cb1d2),lVar6);
    }
    if ((*(longlong *)(param_3 + 0x18) == 0x70) &&
       (plVar3 = (longlong *)*plVar3, plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0x68))(plVar3,1);
    }
    if ((*(longlong *)(param_3 + 0x18) == 0x7c) &&
       (plVar3 = *(longlong **)(param_3 + 0x10), plVar3 != (longlong *)0x0)) {
      (**(code **)(*plVar3 + 0x68))(plVar3,0);
    }
    if (*(longlong *)(param_3 + 0x18) == 0x75) {
      (**(code **)(**(longlong **)(DAT_1800046a0 + 0x729d40) + 0x180))
                (*(longlong **)(DAT_1800046a0 + 0x729d40),*(longlong *)(param_3 + 0x10));
    }
    return 1;
  }
                    /* WARNING: Could not recover jumptable at 0x00018000143e. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  uVar8 = CallNextHookEx(DAT_180004688,param_1,param_2,param_3);
  return uVar8;
}



// ===== __security_check_cookie @ 180001460 =====

/* WARNING: This is an inlined function */

void __cdecl __security_check_cookie(uintptr_t _StackCookie)

{
  if ((_StackCookie == DAT_180004000) && ((short)(_StackCookie >> 0x30) == 0)) {
    return;
  }
  FUN_180001808();
  return;
}



// ===== FUN_180001480 @ 180001480 =====

ulonglong FUN_180001480(undefined8 param_1,int param_2,longlong param_3)

{
  byte bVar1;
  undefined1 uVar2;
  ulonglong uVar3;
  undefined7 extraout_var;
  
  if (param_2 == 0) {
    uVar2 = FUN_1800015e8(CONCAT71((int7)((ulonglong)param_1 >> 8),param_3 != 0));
    return CONCAT71(extraout_var,uVar2);
  }
  if (param_2 != 1) {
    if (param_2 == 2) {
      bVar1 = FUN_180001ad0();
    }
    else {
      if (param_2 != 3) {
        return 1;
      }
      bVar1 = FUN_180001af8();
    }
    return (ulonglong)bVar1;
  }
  uVar3 = FUN_1800014d0(param_1,param_3);
  return uVar3;
}



// ===== FUN_1800014d0 @ 1800014d0 =====

undefined8 FUN_1800014d0(undefined8 param_1,undefined8 param_2)

{
  bool bVar1;
  bool bVar2;
  int iVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  longlong *plVar6;
  ulonglong uVar7;
  
  uVar4 = FUN_180001bb4(0);
  if ((char)uVar4 != '\0') {
    uVar4 = __scrt_acquire_startup_lock();
    bVar1 = true;
    if (DAT_180004620 != 0) {
                    /* WARNING: Subroutine does not return */
      FUN_180001d78(7);
    }
    DAT_180004620 = 1;
    bVar2 = FUN_180001ab8();
    if (bVar2) {
      FUN_180001ec4();
      FUN_180001a00();
      FUN_180001a2c();
      iVar3 = _initterm_e(&DAT_180003188,&DAT_180003190);
      if ((iVar3 == 0) && (uVar5 = __scrt_dllmain_after_initialize_c(), (char)uVar5 != '\0')) {
        _initterm(&DAT_180003168,&DAT_180003180);
        DAT_180004620 = 2;
        bVar1 = false;
      }
    }
    __scrt_release_startup_lock((char)uVar4);
    if (!bVar1) {
      plVar6 = (longlong *)FUN_180001d64();
      if ((*plVar6 != 0) && (uVar7 = FUN_180001c7c((longlong)plVar6), (char)uVar7 != '\0')) {
        (*(code *)PTR__guard_dispatch_icall_180003140)(param_1,2,param_2);
      }
      DAT_180004080 = DAT_180004080 + 1;
      return 1;
    }
  }
  return 0;
}



// ===== FUN_1800015e8 @ 1800015e8 =====

undefined1 FUN_1800015e8(undefined8 param_1)

{
  undefined1 uVar1;
  undefined8 uVar2;
  undefined7 uVar3;
  
  uVar1 = (undefined1)param_1;
  if (DAT_180004080 < 1) {
    uVar1 = 0;
  }
  else {
    DAT_180004080 = DAT_180004080 + -1;
    uVar2 = __scrt_acquire_startup_lock();
    if (DAT_180004620 != 2) {
                    /* WARNING: Subroutine does not return */
      FUN_180001d78(7);
    }
    __scrt_dllmain_uninitialize_c();
    FUN_180001a10();
    FUN_180001f00();
    DAT_180004620 = 0;
    uVar3 = (undefined7)((ulonglong)param_1 >> 8);
    __scrt_release_startup_lock((char)uVar2);
    uVar1 = __scrt_uninitialize_crt(CONCAT71(uVar3,uVar1),'\0');
    FUN_180001ba0();
  }
  return uVar1;
}



// ===== FUN_18000166c @ 18000166c =====

int FUN_18000166c(HMODULE param_1,int param_2,longlong param_3)

{
  ulonglong uVar1;
  undefined8 uVar2;
  HMODULE pHVar3;
  int iVar4;
  
  if ((param_2 == 0) && (DAT_180004080 < 1)) {
    return 0;
  }
  if (param_2 - 1U < 2) {
    if (DAT_1800031c0 == 0) {
      iVar4 = 1;
    }
    else {
      iVar4 = (*(code *)PTR__guard_dispatch_icall_180003140)();
    }
    if (iVar4 == 0) {
      return 0;
    }
    uVar1 = FUN_180001480(param_1,param_2,param_3);
    if ((int)uVar1 == 0) {
      return 0;
    }
  }
  uVar2 = FUN_180001040(param_1,param_2);
  iVar4 = (int)uVar2;
  if ((param_2 == 1) && (iVar4 == 0)) {
    pHVar3 = param_1;
    FUN_180001040(param_1,0);
    FUN_1800015e8(CONCAT71((int7)((ulonglong)pHVar3 >> 8),param_3 != 0));
    if (DAT_1800031c0 != 0) {
      (*(code *)PTR__guard_dispatch_icall_180003140)(param_1,0,param_3);
    }
  }
  if ((param_2 == 0) || (param_2 == 3)) {
    uVar1 = FUN_180001480(param_1,param_2,param_3);
    iVar4 = 0;
    if ((int)uVar1 != 0) {
      if (DAT_1800031c0 == 0) {
        iVar4 = 1;
      }
      else {
        iVar4 = (*(code *)PTR__guard_dispatch_icall_180003140)(param_1,param_2,param_3);
      }
    }
  }
  return iVar4;
}



// ===== entry @ 180001794 =====

void entry(HMODULE param_1,int param_2,longlong param_3)

{
  if (param_2 == 1) {
    FUN_180001950();
  }
  FUN_18000166c(param_1,param_2,param_3);
  return;
}



// ===== __raise_securityfailure @ 1800017d4 =====

/* Library Function - Single Match
    __raise_securityfailure
   
   Libraries: Visual Studio 2015 Release, Visual Studio 2017 Release, Visual Studio 2019 Release */

void __raise_securityfailure(_EXCEPTION_POINTERS *param_1)

{
  HANDLE pvVar1;
  
  SetUnhandledExceptionFilter((LPTOP_LEVEL_EXCEPTION_FILTER)0x0);
  UnhandledExceptionFilter(param_1);
  pvVar1 = GetCurrentProcess();
                    /* WARNING: Could not recover jumptable at 0x000180001801. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  TerminateProcess(pvVar1,0xc0000409);
  return;
}



// ===== FUN_180001808 @ 180001808 =====

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_180001808(void)

{
  code *pcVar1;
  BOOL BVar2;
  undefined1 *puVar3;
  undefined1 auStack_38 [8];
  undefined1 auStack_30 [48];
  
  puVar3 = auStack_38;
  BVar2 = IsProcessorFeaturePresent(0x17);
  if (BVar2 != 0) {
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(2);
    puVar3 = auStack_30;
  }
  *(undefined8 *)(puVar3 + -8) = 0x180001833;
  FUN_1800018dc((PCONTEXT)&DAT_180004130);
  _DAT_1800040a0 = *(undefined8 *)(puVar3 + 0x38);
  _DAT_1800041c8 = puVar3 + 0x40;
  _DAT_1800041b0 = *(undefined8 *)(puVar3 + 0x40);
  _DAT_180004090 = 0xc0000409;
  _DAT_180004094 = 1;
  _DAT_1800040a8 = 1;
  DAT_1800040b0 = 2;
  *(undefined8 *)(puVar3 + 0x20) = DAT_180004000;
  *(undefined8 *)(puVar3 + 0x28) = DAT_180004040;
  *(undefined8 *)(puVar3 + -8) = 0x1800018d5;
  DAT_180004228 = _DAT_1800040a0;
  __raise_securityfailure((_EXCEPTION_POINTERS *)&PTR_DAT_1800031c8);
  return;
}



// ===== FUN_1800018dc @ 1800018dc =====

void FUN_1800018dc(PCONTEXT param_1)

{
  DWORD64 ControlPc;
  PRUNTIME_FUNCTION FunctionEntry;
  int iVar1;
  DWORD64 local_res8;
  ulonglong local_res10;
  PVOID local_res18 [2];
  
  RtlCaptureContext();
  ControlPc = param_1->Rip;
  iVar1 = 0;
  do {
    FunctionEntry = RtlLookupFunctionEntry(ControlPc,&local_res8,(PUNWIND_HISTORY_TABLE)0x0);
    if (FunctionEntry == (PRUNTIME_FUNCTION)0x0) {
      return;
    }
    RtlVirtualUnwind(0,local_res8,ControlPc,FunctionEntry,param_1,local_res18,&local_res10,
                     (PKNONVOLATILE_CONTEXT_POINTERS)0x0);
    iVar1 = iVar1 + 1;
  } while (iVar1 < 2);
  return;
}



// ===== FUN_180001950 @ 180001950 =====

void FUN_180001950(void)

{
  DWORD DVar1;
  _FILETIME local_res8;
  LARGE_INTEGER local_res10;
  _FILETIME local_18 [2];
  
  if (DAT_180004000 == 0x2b992ddfa232) {
    local_res8.dwLowDateTime = 0;
    local_res8.dwHighDateTime = 0;
    GetSystemTimeAsFileTime(&local_res8);
    local_18[0] = local_res8;
    DVar1 = GetCurrentThreadId();
    local_18[0] = (_FILETIME)((ulonglong)local_18[0] ^ (ulonglong)DVar1);
    DVar1 = GetCurrentProcessId();
    local_18[0] = (_FILETIME)((ulonglong)local_18[0] ^ (ulonglong)DVar1);
    QueryPerformanceCounter(&local_res10);
    DAT_180004000 =
         ((ulonglong)local_res10.s.LowPart << 0x20 ^
          CONCAT44(local_res10.s.HighPart,local_res10.s.LowPart) ^ (ulonglong)local_18[0] ^
         (ulonglong)local_18) & 0xffffffffffff;
    if (DAT_180004000 == 0x2b992ddfa232) {
      DAT_180004000 = 0x2b992ddfa233;
    }
  }
  DAT_180004040 = ~DAT_180004000;
  return;
}



// ===== FUN_180001a00 @ 180001a00 =====

void FUN_180001a00(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180001a07. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  InitializeSListHead(&DAT_180004600);
  return;
}



// ===== FUN_180001a10 @ 180001a10 =====

void FUN_180001a10(void)

{
  __std_type_info_destroy_list(&DAT_180004600);
  return;
}



// ===== FUN_180001a1c @ 180001a1c =====

undefined * FUN_180001a1c(void)

{
  return &DAT_180004610;
}



// ===== FUN_180001a24 @ 180001a24 =====

undefined * FUN_180001a24(void)

{
  return &DAT_180004618;
}



// ===== FUN_180001a2c @ 180001a2c =====

void FUN_180001a2c(void)

{
  ulonglong *puVar1;
  
  puVar1 = (ulonglong *)FUN_180001a1c();
  *puVar1 = *puVar1 | 0x24;
  puVar1 = (ulonglong *)FUN_180001a24();
  *puVar1 = *puVar1 | 2;
  return;
}



// ===== __scrt_acquire_startup_lock @ 180001a48 =====

/* Library Function - Single Match
    __scrt_acquire_startup_lock
   
   Libraries: Visual Studio 2015 Release, Visual Studio 2017 Release, Visual Studio 2019 Release */

ulonglong __scrt_acquire_startup_lock(void)

{
  ulonglong uVar1;
  bool bVar2;
  undefined7 extraout_var;
  ulonglong uVar3;
  
  bVar2 = __scrt_is_ucrt_dll_in_use();
  uVar3 = CONCAT71(extraout_var,bVar2);
  if ((int)uVar3 == 0) {
LAB_180001a76:
    uVar3 = uVar3 & 0xffffffffffffff00;
  }
  else {
    do {
      uVar3 = 0;
      LOCK();
      bVar2 = DAT_180004628 == 0;
      uVar1 = *(ulonglong *)((longlong)Self + 8);
      if (!bVar2) {
        uVar3 = DAT_180004628;
        uVar1 = DAT_180004628;
      }
      DAT_180004628 = uVar1;
      UNLOCK();
      if (bVar2) goto LAB_180001a76;
    } while (*(ulonglong *)((longlong)Self + 8) != uVar3);
    uVar3 = CONCAT71((int7)(uVar3 >> 8),1);
  }
  return uVar3;
}



// ===== __scrt_dllmain_after_initialize_c @ 180001a84 =====

/* Library Function - Single Match
    __scrt_dllmain_after_initialize_c
   
   Libraries: Visual Studio 2015 Release, Visual Studio 2017 Release, Visual Studio 2019 Release */

undefined8 __scrt_dllmain_after_initialize_c(void)

{
  bool bVar1;
  undefined7 extraout_var;
  undefined8 uVar2;
  ulonglong uVar3;
  
  bVar1 = __scrt_is_ucrt_dll_in_use();
  if ((int)CONCAT71(extraout_var,bVar1) == 0) {
    uVar3 = FUN_1800021d8();
    uVar3 = _configure_narrow_argv(uVar3 & 0xffffffff);
    if ((int)uVar3 != 0) {
      return uVar3 & 0xffffffffffffff00;
    }
    uVar2 = _initialize_narrow_environment();
  }
  else {
    uVar2 = FUN_180001f40();
  }
  return CONCAT71((int7)((ulonglong)uVar2 >> 8),1);
}



// ===== FUN_180001ab8 @ 180001ab8 =====

bool FUN_180001ab8(void)

{
  undefined8 uVar1;
  
  uVar1 = FUN_180001bf0(0);
  return (char)uVar1 != '\0';
}



// ===== FUN_180001ad0 @ 180001ad0 =====

undefined1 FUN_180001ad0(void)

{
  char cVar1;
  
  cVar1 = FUN_180002234();
  if (cVar1 != '\0') {
    cVar1 = FUN_180002234();
    if (cVar1 != '\0') {
      return 1;
    }
    FUN_180002234();
  }
  return 0;
}



// ===== FUN_180001af8 @ 180001af8 =====

undefined1 FUN_180001af8(void)

{
  FUN_180002234();
  FUN_180002234();
  return 1;
}



// ===== __scrt_dllmain_exception_filter @ 180001b10 =====

/* Library Function - Single Match
    __scrt_dllmain_exception_filter
   
   Libraries: Visual Studio 2017 Release, Visual Studio 2019 Release */

void __scrt_dllmain_exception_filter
               (undefined8 param_1,int param_2,undefined8 param_3,undefined *param_4,
               undefined4 param_5,undefined8 param_6)

{
  bool bVar1;
  undefined7 extraout_var;
  
  bVar1 = __scrt_is_ucrt_dll_in_use();
  if (((int)CONCAT71(extraout_var,bVar1) == 0) && (param_2 == 1)) {
    (*(code *)PTR__guard_dispatch_icall_180003140)(param_1,0,param_3);
  }
  _seh_filter_dll(param_5,param_6);
  return;
}



// ===== __scrt_dllmain_uninitialize_c @ 180001b70 =====

/* Library Function - Single Match
    __scrt_dllmain_uninitialize_c
   
   Libraries: Visual Studio 2015 Release, Visual Studio 2017 Release, Visual Studio 2019 Release */

void __scrt_dllmain_uninitialize_c(void)

{
  bool bVar1;
  undefined7 extraout_var;
  undefined8 uVar2;
  
  bVar1 = __scrt_is_ucrt_dll_in_use();
  if ((int)CONCAT71(extraout_var,bVar1) != 0) {
    _execute_onexit_table(&DAT_180004638);
    return;
  }
  uVar2 = FUN_180002238();
  if ((int)uVar2 == 0) {
    _cexit();
  }
  return;
}



// ===== FUN_180001ba0 @ 180001ba0 =====

void FUN_180001ba0(void)

{
  FUN_180002234();
  FUN_180002234();
  return;
}



// ===== FUN_180001bb4 @ 180001bb4 =====

longlong FUN_180001bb4(int param_1)

{
  char cVar1;
  uint7 extraout_var;
  uint7 uVar2;
  undefined7 extraout_var_00;
  uint7 extraout_var_01;
  
  if (param_1 == 0) {
    DAT_180004630 = 1;
  }
  FUN_180001f40();
  cVar1 = FUN_180002234();
  uVar2 = extraout_var;
  if (cVar1 != '\0') {
    cVar1 = FUN_180002234();
    if (cVar1 != '\0') {
      return CONCAT71(extraout_var_00,1);
    }
    FUN_180002234();
    uVar2 = extraout_var_01;
  }
  return (ulonglong)uVar2 << 8;
}



// ===== FUN_180001bf0 @ 180001bf0 =====

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180001bf0(uint param_1)

{
  bool bVar1;
  ulonglong in_RAX;
  undefined7 extraout_var;
  
  if (DAT_180004631 == '\0') {
    if (1 < param_1) {
                    /* WARNING: Subroutine does not return */
      FUN_180001d78(5);
    }
    bVar1 = __scrt_is_ucrt_dll_in_use();
    if (((int)CONCAT71(extraout_var,bVar1) == 0) || (param_1 != 0)) {
      in_RAX = 0xffffffffffffffff;
      _DAT_180004638 = _DAT_1800031e0;
      uRam0000000180004640 = _UNK_1800031e8;
      _DAT_180004648 = 0xffffffffffffffff;
      _DAT_180004650 = _DAT_1800031e0;
      uRam0000000180004658 = _UNK_1800031e8;
      _DAT_180004660 = 0xffffffffffffffff;
    }
    else {
      in_RAX = _initialize_onexit_table(&DAT_180004638);
      if (((int)in_RAX != 0) ||
         (in_RAX = _initialize_onexit_table(&DAT_180004650), (int)in_RAX != 0)) {
        return in_RAX & 0xffffffffffffff00;
      }
    }
    DAT_180004631 = '\x01';
  }
  return CONCAT71((int7)(in_RAX >> 8),1);
}



// ===== FUN_180001c7c @ 180001c7c =====

ulonglong FUN_180001c7c(longlong param_1)

{
  ulonglong uVar1;
  uint7 uVar2;
  longlong lVar3;
  longlong lVar4;
  
  uVar1 = 0x5a4d;
  if (IMAGE_DOS_HEADER_180000000.e_magic == (char  [2])0x5a4d) {
    lVar3 = (longlong)(int)IMAGE_DOS_HEADER_180000000.e_lfanew;
    if ((*(int *)(lVar3 + 0x180000000) == 0x4550) &&
       (uVar1 = 0x20b,
       *(short *)((longlong)IMAGE_DOS_HEADER_180000000.e_res_4_ + lVar3 + -4) == 0x20b)) {
      lVar4 = (ulonglong)*(ushort *)((longlong)IMAGE_DOS_HEADER_180000000.e_res_4_ + lVar3 + -8) +
              0x18 + lVar3 + 0x180000000;
      uVar1 = (ulonglong)*(ushort *)(IMAGE_DOS_HEADER_180000000.e_magic + lVar3 + 6);
      lVar3 = lVar4 + uVar1 * 0x28;
      for (; lVar4 != lVar3; lVar4 = lVar4 + 0x28) {
        if (((ulonglong)*(uint *)(lVar4 + 0xc) <= param_1 - 0x180000000U) &&
           (uVar1 = (ulonglong)(*(int *)(lVar4 + 8) + *(uint *)(lVar4 + 0xc)),
           param_1 - 0x180000000U < uVar1)) goto LAB_180001cf2;
      }
      lVar4 = 0;
LAB_180001cf2:
      if (lVar4 == 0) {
        return uVar1 & 0xffffffffffffff00;
      }
      uVar2 = (uint7)(uVar1 >> 8);
      if (*(int *)(lVar4 + 0x24) < 0) {
        return (ulonglong)uVar2 << 8;
      }
      return CONCAT71(uVar2,1);
    }
  }
  return uVar1 & 0xffffffffffffff00;
}



// ===== __scrt_release_startup_lock @ 180001d14 =====

/* Library Function - Single Match
    __scrt_release_startup_lock
   
   Libraries: Visual Studio 2015 Release, Visual Studio 2017 Release, Visual Studio 2019 Release */

void __scrt_release_startup_lock(char param_1)

{
  bool bVar1;
  undefined3 extraout_var;
  
  bVar1 = __scrt_is_ucrt_dll_in_use();
  if ((CONCAT31(extraout_var,bVar1) != 0) && (param_1 == '\0')) {
    LOCK();
    DAT_180004628 = 0;
    UNLOCK();
  }
  return;
}



// ===== __scrt_uninitialize_crt @ 180001d38 =====

/* Library Function - Single Match
    __scrt_uninitialize_crt
   
   Library: Visual Studio 2019 Release */

undefined1 __scrt_uninitialize_crt(undefined8 param_1,char param_2)

{
  if ((DAT_180004630 == '\0') || (param_2 == '\0')) {
    FUN_180002234();
    FUN_180002234();
  }
  return 1;
}



// ===== FUN_180001d64 @ 180001d64 =====

undefined * FUN_180001d64(void)

{
  return &DAT_1800046b0;
}



// ===== FUN_180001d6c @ 180001d6c =====

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void FUN_180001d6c(void)

{
  _DAT_180004668 = 0;
  return;
}



// ===== FUN_180001d78 @ 180001d78 =====

void FUN_180001d78(undefined4 param_1)

{
  code *pcVar1;
  BOOL BVar2;
  LONG LVar3;
  PRUNTIME_FUNCTION FunctionEntry;
  undefined1 *puVar4;
  undefined8 unaff_retaddr;
  DWORD64 local_res10;
  undefined1 local_res18 [8];
  undefined1 local_res20 [8];
  undefined1 auStack_5c8 [8];
  undefined1 auStack_5c0 [232];
  undefined1 local_4d8 [152];
  undefined1 *local_440;
  DWORD64 local_3e0;
  
  puVar4 = auStack_5c8;
  BVar2 = IsProcessorFeaturePresent(0x17);
  if (BVar2 != 0) {
    pcVar1 = (code *)swi(0x29);
    (*pcVar1)(param_1);
    puVar4 = auStack_5c0;
  }
  *(undefined8 *)(puVar4 + -8) = 0x180001dac;
  FUN_180001d6c();
  *(undefined8 *)(puVar4 + -8) = 0x180001dbd;
  memset(local_4d8,0,0x4d0);
  *(undefined8 *)(puVar4 + -8) = 0x180001dc7;
  RtlCaptureContext(local_4d8);
  *(undefined8 *)(puVar4 + -8) = 0x180001de1;
  FunctionEntry = RtlLookupFunctionEntry(local_3e0,&local_res10,(PUNWIND_HISTORY_TABLE)0x0);
  if (FunctionEntry != (PRUNTIME_FUNCTION)0x0) {
    *(undefined8 *)(puVar4 + 0x38) = 0;
    *(undefined1 **)(puVar4 + 0x30) = local_res18;
    *(undefined1 **)(puVar4 + 0x28) = local_res20;
    *(undefined1 **)(puVar4 + 0x20) = local_4d8;
    *(undefined8 *)(puVar4 + -8) = 0x180001e25;
    RtlVirtualUnwind(0,local_res10,local_3e0,FunctionEntry,*(PCONTEXT *)(puVar4 + 0x20),
                     *(PVOID **)(puVar4 + 0x28),*(PDWORD64 *)(puVar4 + 0x30),
                     *(PKNONVOLATILE_CONTEXT_POINTERS *)(puVar4 + 0x38));
  }
  local_440 = &stack0x00000008;
  *(undefined8 *)(puVar4 + -8) = 0x180001e57;
  memset(puVar4 + 0x50,0,0x98);
  *(undefined8 *)(puVar4 + 0x60) = unaff_retaddr;
  *(undefined4 *)(puVar4 + 0x50) = 0x40000015;
  *(undefined4 *)(puVar4 + 0x54) = 1;
  *(undefined8 *)(puVar4 + -8) = 0x180001e79;
  BVar2 = IsDebuggerPresent();
  *(undefined1 **)(puVar4 + 0x40) = puVar4 + 0x50;
  *(undefined1 **)(puVar4 + 0x48) = local_4d8;
  *(undefined8 *)(puVar4 + -8) = 0x180001e96;
  SetUnhandledExceptionFilter((LPTOP_LEVEL_EXCEPTION_FILTER)0x0);
  *(undefined8 *)(puVar4 + -8) = 0x180001ea1;
  LVar3 = UnhandledExceptionFilter((_EXCEPTION_POINTERS *)(puVar4 + 0x40));
  if ((LVar3 == 0) && (BVar2 != 1)) {
    *(undefined8 *)(puVar4 + -8) = 0x180001eb2;
    FUN_180001d6c();
  }
  return;
}



// ===== FUN_180001ec4 @ 180001ec4 =====

void FUN_180001ec4(void)

{
  longlong *plVar1;
  
  for (plVar1 = &DAT_180003748; plVar1 < &DAT_180003748; plVar1 = plVar1 + 1) {
    if (*plVar1 != 0) {
      (*(code *)PTR__guard_dispatch_icall_180003140)();
    }
  }
  return;
}



// ===== FUN_180001f00 @ 180001f00 =====

void FUN_180001f00(void)

{
  longlong *plVar1;
  
  for (plVar1 = &DAT_180003758; plVar1 < &DAT_180003758; plVar1 = plVar1 + 1) {
    if (*plVar1 != 0) {
      (*(code *)PTR__guard_dispatch_icall_180003140)();
    }
  }
  return;
}



// ===== _guard_check_icall @ 180001f3c =====

void _guard_check_icall(void)

{
  return;
}



// ===== FUN_180001f40 @ 180001f40 =====

/* WARNING: Removing unreachable block (ram,0x000180002031) */
/* WARNING: Removing unreachable block (ram,0x000180002021) */
/* WARNING: Removing unreachable block (ram,0x000180001ffc) */
/* WARNING: Removing unreachable block (ram,0x000180001f7a) */
/* WARNING: Removing unreachable block (ram,0x000180001f58) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 FUN_180001f40(void)

{
  int *piVar1;
  uint *puVar2;
  int *piVar3;
  longlong lVar4;
  uint uVar5;
  byte bVar6;
  ulonglong uVar7;
  uint uVar8;
  ulonglong uVar9;
  uint uVar10;
  uint uVar11;
  ulonglong uVar12;
  ulonglong in_XCR0;
  
  piVar1 = (int *)cpuid_basic_info(0);
  puVar2 = (uint *)cpuid_Version_info(1);
  uVar5 = puVar2[3];
  if ((piVar1[2] == 0x49656e69 && piVar1[3] == 0x6c65746e) && piVar1[1] == 0x756e6547) {
    uVar8 = *puVar2 & 0xfff3ff0;
    _DAT_180004060 = 0x8000;
    _DAT_180004068 = 0xffffffffffffffff;
    if ((((uVar8 == 0x106c0) || (uVar8 == 0x20660)) || (uVar8 == 0x20670)) ||
       ((uVar8 - 0x30650 < 0x21 &&
        ((0x100010001U >> ((ulonglong)(uVar8 - 0x30650) & 0x3f) & 1) != 0)))) {
      DAT_180004670 = DAT_180004670 | 1;
    }
  }
  uVar8 = 0;
  uVar10 = 0;
  uVar11 = 0;
  uVar12 = 0;
  if (6 < *piVar1) {
    piVar3 = (int *)cpuid_Extended_Feature_Enumeration_info(7);
    uVar8 = piVar3[1];
    uVar10 = piVar3[2];
    if ((uVar8 >> 9 & 1) != 0) {
      DAT_180004670 = DAT_180004670 | 2;
    }
    if (0 < *piVar3) {
      lVar4 = cpuid_Extended_Feature_Enumeration_info(7);
      uVar11 = *(uint *)(lVar4 + 8);
    }
    if (0x23 < *piVar1) {
      lVar4 = cpuid(0x24);
      uVar12 = (ulonglong)*(uint *)(lVar4 + 4);
    }
  }
  _DAT_180004058 = 1;
  DAT_18000405c = 2;
  uVar9 = DAT_180004050 & 0xfffffffffffffffe;
  if ((uVar5 >> 0x14 & 1) != 0) {
    _DAT_180004058 = 2;
    DAT_18000405c = 6;
    uVar9 = DAT_180004050 & 0xffffffffffffffee;
  }
  DAT_180004050 = uVar9;
  if ((uVar5 >> 0x1b & 1) != 0) {
    uVar9 = xinuse(0);
    uVar9 = in_XCR0 & uVar9 & 0xffffffff;
    if (((uVar5 >> 0x1c & 1) != 0) && (bVar6 = (byte)uVar9, (bVar6 & 6) == 6)) {
      _DAT_180004058 = 3;
      uVar7 = DAT_180004050;
      uVar5 = DAT_18000405c | 8;
      if ((uVar8 & 0x20) != 0) {
        _DAT_180004058 = 5;
        uVar7 = DAT_180004050 & 0xfffffffffffffffd;
        uVar5 = DAT_18000405c | 0x28;
        if (((uVar8 & 0xd0030000) == 0xd0030000) && ((bVar6 & 0xe0) == 0xe0)) {
          DAT_18000405c = DAT_18000405c | 0x68;
          _DAT_180004058 = 6;
          uVar7 = DAT_180004050 & 0xffffffffffffffd9;
          uVar5 = DAT_18000405c;
        }
      }
      DAT_18000405c = uVar5;
      DAT_180004050 = uVar7;
      if ((uVar10 >> 0x17 & 1) != 0) {
        DAT_180004050 = DAT_180004050 & 0xfffffffffeffffff;
      }
      if (((uVar11 >> 0x13 & 1) != 0) && ((bVar6 & 0xe0) == 0xe0)) {
        _DAT_18000466c = (uint)uVar12 & 0x400ff;
        DAT_180004050 = ~((ulonglong)((uint)(uVar12 >> 0x10) & 6) | 0x1000029) & DAT_180004050;
        if (1 < (byte)_DAT_18000466c) {
          DAT_180004050 = DAT_180004050 & 0xffffffffffffffbf;
        }
      }
    }
    if (((uVar11 >> 0x15 & 1) != 0) && ((uVar9 >> 0x13 & 1) != 0)) {
      DAT_180004050 = DAT_180004050 & 0xffffffffffffff7f;
    }
  }
  return 0;
}



// ===== FUN_1800021d8 @ 1800021d8 =====

undefined8 FUN_1800021d8(void)

{
  return 1;
}



// ===== __scrt_is_ucrt_dll_in_use @ 1800021e0 =====

/* Library Function - Single Match
    __scrt_is_ucrt_dll_in_use
   
   Libraries: Visual Studio 2017 Release, Visual Studio 2019 Release */

bool __scrt_is_ucrt_dll_in_use(void)

{
  return DAT_180004070 != 0;
}



// ===== __std_type_info_destroy_list @ 1800021f6 =====

void __std_type_info_destroy_list(void)

{
                    /* WARNING: Could not recover jumptable at 0x0001800021f6. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  __std_type_info_destroy_list();
  return;
}



// ===== memset @ 1800021fc =====

void * __cdecl memset(void *_Dst,int _Val,size_t _Size)

{
  void *pvVar1;
  
                    /* WARNING: Could not recover jumptable at 0x0001800021fc. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  pvVar1 = memset(_Dst,_Val,_Size);
  return pvVar1;
}



// ===== _initterm @ 180002202 =====

void _initterm(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180002202. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _initterm();
  return;
}



// ===== _initterm_e @ 180002208 =====

void _initterm_e(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180002208. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _initterm_e();
  return;
}



// ===== _seh_filter_dll @ 18000220e =====

void _seh_filter_dll(void)

{
                    /* WARNING: Could not recover jumptable at 0x00018000220e. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _seh_filter_dll();
  return;
}



// ===== _configure_narrow_argv @ 180002214 =====

void _configure_narrow_argv(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180002214. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _configure_narrow_argv();
  return;
}



// ===== _initialize_narrow_environment @ 18000221a =====

void _initialize_narrow_environment(void)

{
                    /* WARNING: Could not recover jumptable at 0x00018000221a. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _initialize_narrow_environment();
  return;
}



// ===== _initialize_onexit_table @ 180002220 =====

void _initialize_onexit_table(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180002220. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _initialize_onexit_table();
  return;
}



// ===== _execute_onexit_table @ 180002226 =====

void _execute_onexit_table(void)

{
                    /* WARNING: Could not recover jumptable at 0x000180002226. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _execute_onexit_table();
  return;
}



// ===== _cexit @ 18000222c =====

void __cdecl _cexit(void)

{
                    /* WARNING: Could not recover jumptable at 0x00018000222c. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  _cexit();
  return;
}



// ===== FUN_180002234 @ 180002234 =====

undefined1 FUN_180002234(void)

{
  return 1;
}



// ===== FUN_180002238 @ 180002238 =====

undefined8 FUN_180002238(void)

{
  return 0;
}



// ===== _guard_dispatch_icall @ 180002260 =====

/* WARNING: This is an inlined function */

void _guard_dispatch_icall(void)

{
  code *UNRECOVERED_JUMPTABLE;
  
                    /* WARNING: Could not recover jumptable at 0x000180002260. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*UNRECOVERED_JUMPTABLE)();
  return;
}



// ===== _guard_dispatch_icall @ 180002280 =====

/* WARNING: This is an inlined function */
/* WARNING: Switch with 1 destination removed at 0x000180002280 */

void _guard_dispatch_icall(void)

{
  code *UNRECOVERED_JUMPTABLE;
  
                    /* WARNING: Could not recover jumptable at 0x000180002260. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  (*UNRECOVERED_JUMPTABLE)();
  return;
}



// ===== FUN_180002286 @ 180002286 =====

void FUN_180002286(undefined8 param_1,longlong param_2)

{
  __scrt_release_startup_lock(*(char *)(param_2 + 0x40));
  return;
}



// ===== FUN_18000229d @ 18000229d =====

void FUN_18000229d(undefined8 param_1,longlong param_2)

{
  __scrt_release_startup_lock(*(char *)(param_2 + 0x20));
  return;
}



// ===== FUN_1800022b6 @ 1800022b6 =====

void FUN_1800022b6(void)

{
  FUN_180001ba0();
  return;
}



// ===== FUN_1800022ca @ 1800022ca =====

void FUN_1800022ca(undefined8 *param_1,longlong param_2)

{
  __scrt_dllmain_exception_filter
            (*(undefined8 *)(param_2 + 0x60),*(int *)(param_2 + 0x68),
             *(undefined8 *)(param_2 + 0x70),FUN_180001480,*(undefined4 *)*param_1,param_1);
  return;
}



// ===== FUN_180002300 @ 180002300 =====

bool FUN_180002300(undefined8 *param_1)

{
  return *(int *)*param_1 == -0x3ffffffb;
}


