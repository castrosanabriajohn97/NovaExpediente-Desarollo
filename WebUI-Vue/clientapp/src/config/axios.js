/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "axios";

export default Axios.create({
  baseURL: process.env.VUE_APP_RUTA_RAIZ,
  headers: { "Content-Type": "application/json" }
});

