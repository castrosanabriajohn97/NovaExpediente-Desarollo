/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "../../../config/axios";

export const GetClientes = () => Axios.get("/Cliente/GetClientes");

export const GetClientesReferencias = () => Axios.get("/Cliente/GetClientesReferencias");