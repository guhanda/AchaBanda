package com.app.achabandatst1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.google.gson.Gson;
import com.squareup.picasso.Picasso;

import org.w3c.dom.Text;

public class ItemActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_item);

        Button btn = (Button) findViewById(R.id.btnItemFechar);
        TextView textNome = (TextView) findViewById(R.id.textNome);

        String jsonMyObject="";
        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            jsonMyObject = extras.getString("myObject");
        }

        Usuario myObject = new Gson().fromJson(jsonMyObject, Usuario.class);

        ImageView imgVIew = (ImageView) findViewById(R.id.imgViewItem);

        Picasso.with(this).load(myObject.getUrlImage()).into(imgVIew);

        textNome.setText(myObject.getNomeUsuario());

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

    }
}
