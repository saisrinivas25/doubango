/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class XcapSelector : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XcapSelector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XcapSelector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XcapSelector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_XcapSelector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public XcapSelector(XcapStack stack) : this(tinyWRAPPINVOKE.new_XcapSelector(XcapStack.getCPtr(stack)), true) {
  }

  public XcapSelector setAUID(string auid) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setAUID(swigCPtr, auid);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public XcapSelector setName(string qname) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setName(swigCPtr, qname);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public XcapSelector setAttribute(string qname, string att_qname, string att_value) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setAttribute(swigCPtr, qname, att_qname, att_value);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public XcapSelector setPos(string qname, uint pos) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setPos(swigCPtr, qname, pos);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public XcapSelector setPosAttribute(string qname, uint pos, string att_qname, string att_value) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setPosAttribute(swigCPtr, qname, pos, att_qname, att_value);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public XcapSelector setNamespace(string prefix, string value) {
    IntPtr cPtr = tinyWRAPPINVOKE.XcapSelector_setNamespace(swigCPtr, prefix, value);
    XcapSelector ret = (cPtr == IntPtr.Zero) ? null : new XcapSelector(cPtr, false);
    return ret;
  }

  public string getString() {
    string ret = tinyWRAPPINVOKE.XcapSelector_getString(swigCPtr);
    return ret;
  }

  public void reset() {
    tinyWRAPPINVOKE.XcapSelector_reset(swigCPtr);
  }

}

}
