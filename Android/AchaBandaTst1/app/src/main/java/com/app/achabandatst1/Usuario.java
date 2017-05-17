package com.app.achabandatst1;
import android.graphics.Bitmap;
import android.media.Image;
import android.widget.ImageView;

import java.net.URL;
import java.util.BitSet;
import java.util.List;

/**
 * Created by gusta on 26/04/2017.
 */

public class Usuario {
    private int IdUsuario;
    private String NomeUsuario;
    private List<String> Estilos;
    private Instrumento Instrumento;
    private String UrlImage;

    public String getUrlImage() {
        return UrlImage;
    }

    public void setUrlImage(String urlImage) {
        UrlImage = urlImage;
    }

    public Usuario()
    {

    }

    public int getIdUsuario() {
        return IdUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        IdUsuario = idUsuario;
    }

    public String getNomeUsuario() {
        return NomeUsuario;
    }

    public void setNomeUsuario(String nomeUsuario) {
        NomeUsuario = nomeUsuario;
    }


    public List<String> getEstilos() {
        return Estilos;
    }

    public void setEstilos(List<String> estilos) {
        Estilos = estilos;
    }

    public Instrumento getInstrumento() {
        return Instrumento;
    }

    public void setInstrumento(Instrumento instrumento) {
        Instrumento = instrumento;
    }
}

