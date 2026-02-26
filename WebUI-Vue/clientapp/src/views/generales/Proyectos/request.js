/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "../../../config/axios";


export const GetDetail = id =>
  Axios.get("/Colaborador/GetDetail", {
    params: { id }
  });



export const GetProyectos = () => Axios.get("/Proyecto/GetProyectos");