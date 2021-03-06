package com.app.achabandatst1;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.media.Image;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.util.Log;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.ListAdapter;
import android.widget.Toast;

import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import static com.app.achabandatst1.R.id.imageView;

public class MainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    // Keep all Images in array
    public Integer[] mThumbIds = {
            R.drawable.ic_menu_camera,R.drawable.ic_menu_camera,
            R.drawable.ic_menu_camera,R.drawable.ic_menu_camera,
            R.drawable.ic_menu_camera,R.drawable.ic_menu_camera,
            R.drawable.ic_menu_camera,R.drawable.ic_menu_camera,
            R.drawable.ic_menu_camera,R.drawable.ic_menu_camera
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        //
        String[] inst = getResources().getStringArray(R.array.Instrumentos);
        String[] est = getResources().getStringArray(R.array.Estilos);
        String[] usu = getResources().getStringArray(R.array.Usuarios);
        List<String> list = new ArrayList<>();

        ArrayList<Usuario> listaUsuario = new ArrayList<Usuario>();

        for (int i=0;i<=20;i++)
        {
            Random r = new Random();
            Usuario usuario = new Usuario();

            usuario.setIdUsuario(i);

            ArrayList<String> listaEstilo = new ArrayList<>();
            listaEstilo.add(est[r.nextInt(est.length)]);
            usuario.setEstilos(listaEstilo);

            Instrumento instrumento = new Instrumento();
            instrumento.setInstrumento(inst[r.nextInt(inst.length)]);
            instrumento.setClassificacao(r.nextInt(5));

            int nota = r.nextInt(5);
            instrumento.setClassificacao(nota);
            usuario.setInstrumento(instrumento);

            usuario.setNomeUsuario(usu[r.nextInt(usu.length)]);
            //
            list.add(usu[r.nextInt(usu.length)]);

            //String imageURL = "https://pbs.twimg.com/profile_images/630285593268752384/iD1MkFQ0.png";

            String imageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwuD2r6tP3EeFjKXxB9vsHhOmCCDsOBCC85iACXbxBS6nI-SNh";
            usuario.setUrlImage(imageURL);
            /////

            listaUsuario.add(usuario);

        }
        //
        GridView gridview = (GridView) findViewById(R.id.gridView);
        gridview.setAdapter(new ImageAdapter(this,mThumbIds,listaUsuario));

        /////
        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        if (id == R.id.nav_camera) {
            // Handle the camera action
        } else if (id == R.id.nav_gallery) {

        } else if (id == R.id.nav_slideshow) {

        } else if (id == R.id.nav_manage) {

        } else if (id == R.id.nav_share) {

        } else if (id == R.id.nav_send) {

        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }

}

