/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import AxiosSecurity from "axios";

export default AxiosSecurity.create({
  baseURL: process.env.VUE_APP_RUTA_SEGURIDAD,
  headers: { "Content-Type": "application/json" }
});

