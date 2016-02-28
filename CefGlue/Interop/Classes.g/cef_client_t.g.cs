﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_client_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_context_menu_handler;
        internal IntPtr _get_dialog_handler;
        internal IntPtr _get_display_handler;
        internal IntPtr _get_download_handler;
        internal IntPtr _get_drag_handler;
        internal IntPtr _get_find_handler;
        internal IntPtr _get_focus_handler;
        internal IntPtr _get_geolocation_handler;
        internal IntPtr _get_jsdialog_handler;
        internal IntPtr _get_keyboard_handler;
        internal IntPtr _get_life_span_handler;
        internal IntPtr _get_load_handler;
        internal IntPtr _get_render_handler;
        internal IntPtr _get_request_handler;
        internal IntPtr _on_process_message_received;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_context_menu_handler_t* get_context_menu_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_dialog_handler_t* get_dialog_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_display_handler_t* get_display_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_download_handler_t* get_download_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_drag_handler_t* get_drag_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_find_handler_t* get_find_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_focus_handler_t* get_focus_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_geolocation_handler_t* get_geolocation_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_jsdialog_handler_t* get_jsdialog_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_keyboard_handler_t* get_keyboard_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_life_span_handler_t* get_life_span_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_load_handler_t* get_load_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_render_handler_t* get_render_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_request_handler_t* get_request_handler_delegate(cef_client_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_process_message_received_delegate(cef_client_t* self, cef_browser_t* browser, CefProcessId source_process, cef_process_message_t* message);
        
        private static int _sizeof;
        
        static cef_client_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_client_t));
        }
        
        internal static cef_client_t* Alloc()
        {
            var ptr = (cef_client_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_client_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_client_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
