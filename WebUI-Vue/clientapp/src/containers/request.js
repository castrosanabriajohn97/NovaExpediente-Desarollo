/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "../config/axios";


export const GetPhoto = email =>
  Axios.get("/Colaborador/GetPhotoByEmail", {
    params: { email }
  });

  export const GetInfoColaborador = email =>
  Axios.get("/Colaborador/GetInfoByEmail", {
    params: { email }
  });

  export const GetContextoSeguridad = () => Axios.get("/CurrentUser/GetSecurityContext");
