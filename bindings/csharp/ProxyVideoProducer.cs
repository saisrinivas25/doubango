/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ProxyVideoProducer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProxyVideoProducer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyVideoProducer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyVideoProducer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_ProxyVideoProducer(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ProxyVideoProducer(tmedia_chroma_t chroma) : this(tinyWRAPPINVOKE.new_ProxyVideoProducer((int)chroma), true) {
    SwigDirectorConnect();
  }

  public virtual int prepare(int width, int height, int fps) {
    int ret = ((this.GetType() == typeof(ProxyVideoProducer)) ? tinyWRAPPINVOKE.ProxyVideoProducer_prepare(swigCPtr, width, height, fps) : tinyWRAPPINVOKE.ProxyVideoProducer_prepareSwigExplicitProxyVideoProducer(swigCPtr, width, height, fps));
    return ret;
  }

  public virtual int start() {
    int ret = ((this.GetType() == typeof(ProxyVideoProducer)) ? tinyWRAPPINVOKE.ProxyVideoProducer_start(swigCPtr) : tinyWRAPPINVOKE.ProxyVideoProducer_startSwigExplicitProxyVideoProducer(swigCPtr));
    return ret;
  }

  public virtual int pause() {
    int ret = ((this.GetType() == typeof(ProxyVideoProducer)) ? tinyWRAPPINVOKE.ProxyVideoProducer_pause(swigCPtr) : tinyWRAPPINVOKE.ProxyVideoProducer_pauseSwigExplicitProxyVideoProducer(swigCPtr));
    return ret;
  }

  public virtual int stop() {
    int ret = ((this.GetType() == typeof(ProxyVideoProducer)) ? tinyWRAPPINVOKE.ProxyVideoProducer_stop(swigCPtr) : tinyWRAPPINVOKE.ProxyVideoProducer_stopSwigExplicitProxyVideoProducer(swigCPtr));
    return ret;
  }

  public void setActivate(bool enabled) {
    tinyWRAPPINVOKE.ProxyVideoProducer_setActivate(swigCPtr, enabled);
  }

  public int push(byte[] buffer, uint size) {
    int ret = tinyWRAPPINVOKE.ProxyVideoProducer_push(swigCPtr, buffer, size);
    return ret;
  }

  public static bool registerPlugin() {
    bool ret = tinyWRAPPINVOKE.ProxyVideoProducer_registerPlugin();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("prepare", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateProxyVideoProducer_0(SwigDirectorprepare);
    if (SwigDerivedClassHasMethod("start", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateProxyVideoProducer_1(SwigDirectorstart);
    if (SwigDerivedClassHasMethod("pause", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateProxyVideoProducer_2(SwigDirectorpause);
    if (SwigDerivedClassHasMethod("stop", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateProxyVideoProducer_3(SwigDirectorstop);
    tinyWRAPPINVOKE.ProxyVideoProducer_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ProxyVideoProducer));
    return hasDerivedMethod;
  }

  private int SwigDirectorprepare(int width, int height, int fps) {
    return prepare(width, height, fps);
  }

  private int SwigDirectorstart() {
    return start();
  }

  private int SwigDirectorpause() {
    return pause();
  }

  private int SwigDirectorstop() {
    return stop();
  }

  public delegate int SwigDelegateProxyVideoProducer_0(int width, int height, int fps);
  public delegate int SwigDelegateProxyVideoProducer_1();
  public delegate int SwigDelegateProxyVideoProducer_2();
  public delegate int SwigDelegateProxyVideoProducer_3();

  private SwigDelegateProxyVideoProducer_0 swigDelegate0;
  private SwigDelegateProxyVideoProducer_1 swigDelegate1;
  private SwigDelegateProxyVideoProducer_2 swigDelegate2;
  private SwigDelegateProxyVideoProducer_3 swigDelegate3;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(int), typeof(int), typeof(int) };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
}
