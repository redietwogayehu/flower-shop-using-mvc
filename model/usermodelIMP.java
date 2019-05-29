package com.example.mvp.model;

import android.text.TextUtils;

import com.example.mvp.model.entityy.User;

public class usermodelIMP implements userModel {
    @Override
    public void login(User user, Callback callback) {
        if(TextUtils.isEmpty(user.getUsername())){
            callback.onUsernameError("user empty");
            return;

    }
        if (TextUtils.isEmpty(user.getPassword())){
            callback.onpasswordError("pass empty");
            return;
        }
        if(user.getUsername().equals("admin") && user.getPassword().equals("admin")){
          callback.onSuccess("login success");
        }else{
        callback.onFail("username or password invalidate");
        }
    }

    @Override
    public void login(String username, String password, Callback callback) {

    }
}
