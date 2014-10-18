//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefRenderHandler
    {
        private static Dictionary<IntPtr, CefRenderHandler> _roots = new Dictionary<IntPtr, CefRenderHandler>();
        
        private int _refct;
        private cef_render_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_render_handler_t.add_ref_delegate _ds0;
        private cef_render_handler_t.release_delegate _ds1;
        private cef_render_handler_t.has_one_ref_delegate _ds2;
        private cef_render_handler_t.get_root_screen_rect_delegate _ds3;
        private cef_render_handler_t.get_view_rect_delegate _ds4;
        private cef_render_handler_t.get_screen_point_delegate _ds5;
        private cef_render_handler_t.get_screen_info_delegate _ds6;
        private cef_render_handler_t.on_popup_show_delegate _ds7;
        private cef_render_handler_t.on_popup_size_delegate _ds8;
        private cef_render_handler_t.on_paint_delegate _ds9;
        private cef_render_handler_t.on_cursor_change_delegate _dsa;
        private cef_render_handler_t.start_dragging_delegate _dsb;
        private cef_render_handler_t.update_drag_cursor_delegate _dsc;
        private cef_render_handler_t.on_scroll_offset_changed_delegate _dsd;
        
        protected CefRenderHandler()
        {
            _self = cef_render_handler_t.Alloc();
        
            _ds0 = new cef_render_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_render_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_render_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_render_handler_t.get_root_screen_rect_delegate(get_root_screen_rect);
            _self->_get_root_screen_rect = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_render_handler_t.get_view_rect_delegate(get_view_rect);
            _self->_get_view_rect = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_render_handler_t.get_screen_point_delegate(get_screen_point);
            _self->_get_screen_point = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_render_handler_t.get_screen_info_delegate(get_screen_info);
            _self->_get_screen_info = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_render_handler_t.on_popup_show_delegate(on_popup_show);
            _self->_on_popup_show = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_render_handler_t.on_popup_size_delegate(on_popup_size);
            _self->_on_popup_size = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_render_handler_t.on_paint_delegate(on_paint);
            _self->_on_paint = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_render_handler_t.on_cursor_change_delegate(on_cursor_change);
            _self->_on_cursor_change = Marshal.GetFunctionPointerForDelegate(_dsa);
            _dsb = new cef_render_handler_t.start_dragging_delegate(start_dragging);
            _self->_start_dragging = Marshal.GetFunctionPointerForDelegate(_dsb);
            _dsc = new cef_render_handler_t.update_drag_cursor_delegate(update_drag_cursor);
            _self->_update_drag_cursor = Marshal.GetFunctionPointerForDelegate(_dsc);
            _dsd = new cef_render_handler_t.on_scroll_offset_changed_delegate(on_scroll_offset_changed);
            _self->_on_scroll_offset_changed = Marshal.GetFunctionPointerForDelegate(_dsd);
        }
        
        ~CefRenderHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_render_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_render_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_render_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_render_handler_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        internal cef_render_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_render_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
