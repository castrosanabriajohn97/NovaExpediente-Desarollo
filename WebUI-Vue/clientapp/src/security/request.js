/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
import AxiosSecurity from "../config/axiosSecurity";


  export const GetClockService = () => AxiosSecurity.get("/ClockService");



  