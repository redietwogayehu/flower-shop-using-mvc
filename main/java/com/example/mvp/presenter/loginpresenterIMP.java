package com.example.mvp.presenter;

import com.example.mvp.model.entityy.User;
import com.example.mvp.model.userModel;
import com.example.mvp.model.usermodelIMP;
import com.example.mvp.view.loginView;

public class loginpresenterIMP implements loginpresenter, userModel.Callback {
    private loginView mloginview;
    private userModel musermodel;
    public loginpresenterIMP(loginView mloginview){
        this.mloginview = mloginview;
        this.musermodel = new usermodelIMP();
    }
    @Override
    public void login(User user) {
musermodel.login(user,this);
    }


    @Override
    public void onUsernameError(String msg) {
        mloginview.showUsernameError(msg);
    }

    @Override
    public void onpasswordError(String msg) {
     mloginview.showPassowrdError(msg);
    }

    @Override
    public void onSuccess(String successMessage) {
     mloginview.showLoginsuccess(successMessage);
     mloginview.navigate();
    }

    @Override
    public void onFail(String msg) {
        mloginview.showLoginfail(msg);
    }
}
