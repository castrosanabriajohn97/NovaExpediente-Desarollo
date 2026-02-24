/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import Axios from "../../../config/axios";

export const GetEspecialidad = () => Axios.get("/Especialidad/GetEspecialidad");