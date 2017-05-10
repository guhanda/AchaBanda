package com.app.achabandatst1;
import android.media.Image;
import android.widget.ImageView;

import java.util.List;

/**
 * Created by gusta on 26/04/2017.
 */

public class Usuario {
    private int IdUsuario;
    private String NomeUsuario;
    private ImageView ImagemUsuario;
    private List<String> Estilos;
    private Instrumento Instrumento;

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

    public ImageView getImagemUsuario() {
        return ImagemUsuario;
    }

    public void setImagemUsuario(ImageView imagemUsuario) {
        ImagemUsuario = imagemUsuario;
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

