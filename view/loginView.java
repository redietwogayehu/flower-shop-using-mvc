package com.example.mvp.view;

public interface loginView {

void showUsernameError(String msg);
void showPassowrdError(String msg);
void showLoginsuccess(String msg);

    void showLoginfail(String msg);
    void navigate();
}

