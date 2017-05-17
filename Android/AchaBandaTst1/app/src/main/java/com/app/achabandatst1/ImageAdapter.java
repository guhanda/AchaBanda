package com.app.achabandatst1;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.Parcelable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.ListAdapter;
import android.widget.TextView;
import android.widget.Toast;

import com.google.gson.Gson;
import com.squareup.picasso.Picasso;

import java.io.Serializable;
import java.util.ArrayList;

/**
 * Created by gusta on 10/05/2017.
 */

public class ImageAdapter extends BaseAdapter {
    private Context mContext;
    private final Integer[] mThumbIds;
    private ArrayList<Usuario> mUsuario;

    public ImageAdapter(Context context, Integer[] mThumbIds, ArrayList<Usuario> usuario) {
        this.mContext = context;
        this.mThumbIds = mThumbIds;
        this.mUsuario = usuario;
    }

    public int getCount() {
        return 10;
    }

    public Object getItem(int position) {
        return null;
    }

    public long getItemId(int position) {
        return 0;
    }

    public View getView(final int position, View convertView, ViewGroup parent) {

        LayoutInflater inflater = (LayoutInflater) mContext
                .getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        View gridView;

        if (convertView == null) {
            // get layout from mobile.xml
            gridView = inflater.inflate(R.layout.item, null);

            // set image based on selected text
            ImageView imageView = (ImageView) gridView
                    .findViewById(R.id.grid_item_image);

            TextView textView = (TextView) gridView.findViewById(R.id.grid_item_text);

            textView.setText(mUsuario.get(position).getNomeUsuario());

            Picasso.with(mContext).load(mUsuario.get(position).getUrlImage()).into(imageView);

            gridView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    Intent i = new Intent(mContext, ItemActivity.class);
                    Usuario usuarioSelecionado = mUsuario.get(1);
                    i.putExtra("myObject", new Gson().toJson(usuarioSelecionado));
                    mContext.startActivity(i);

                    //Toast.makeText(mContext, "OKOK", Toast.LENGTH_SHORT).show();
                }
            });




        } else {
            gridView = (View) convertView;
        }

        return gridView;
    }

}
