/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
<template>
  <div>
    <vue-editor
      v-model="context.model"
      :disabled="context.attributes.disabled"
    ></vue-editor>
  </div>
</template>

<script>
import { VueEditor } from "vue2-editor";

export default {
  name: "RichTextBox",
  props: {
    context: {
      type: Object,
      required: true,
    },
    disabled: {
      type: Boolean,
      default: false,
    },
  },
  components: {
    VueEditor,
  },
};
</script>