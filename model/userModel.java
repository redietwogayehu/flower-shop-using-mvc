package com.example.mvp.model;

import com.example.mvp.model.entityy.User;

public interface userModel {
    void login(User user, Callback callback);
    void login(String username, String password, Callback callback);

    interface Callback{
        void onUsernameError(String msg);
        void onpasswordError(String msg);
        void onSuccess(String successMessage);
        void onFail(String msg);
    }

}
