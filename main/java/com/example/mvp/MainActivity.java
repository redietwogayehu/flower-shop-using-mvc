package com.example.mvp;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.example.mvp.model.entityy.User;
import com.example.mvp.presenter.loginpresenter;
import com.example.mvp.presenter.loginpresenterIMP;
import com.example.mvp.view.loginView;

public class MainActivity extends AppCompatActivity implements loginView {
private loginpresenter mloginpresenter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setupMVP();
    }
private void setupMVP(){
        mloginpresenter = new loginpresenterIMP(this);
}

    @Override
    public void showUsernameError(String msg) {
        Toast.makeText(this,msg, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void showPassowrdError(String msg) {
        Toast.makeText(this,msg, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void showLoginsuccess(String msg) {
        Toast.makeText(this,msg, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void showLoginfail(String msg) {
        Toast.makeText(this,msg, Toast.LENGTH_SHORT).show();
    }

    @Override
    public void navigate() {
        Intent intent = new Intent(this,Main2Activity.class);
        startActivity(intent);
    }

    public void login(View view) {
        String username = ((EditText)findViewById(R.id.username)).getText().toString();
        String pass = ((EditText)findViewById(R.id.username)).getText().toString();
        mloginpresenter.login(new User(username,pass));
    }
}
