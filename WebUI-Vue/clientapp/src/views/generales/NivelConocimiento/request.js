/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "../../../config/axios";

export const GetAllIdiomas = () => Axios.get("/Idiomas/GetAll");

export const GetNivelIdioma = () => Axios.get("/NivelIdioma/GetNivelIdioma");

export const GetNivelIdiomaXIdioma = id =>
  Axios.get("/NivelIdioma/GetNivelIdiomaXIdioma", {
    params: { id }
  });